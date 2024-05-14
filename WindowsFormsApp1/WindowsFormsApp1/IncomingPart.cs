using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IncomingPart : Form
    {

        MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem");
        MySqlCommand command;
        MySqlDataAdapter adapter;

        public IncomingPart()
        {
            InitializeComponent();
        }


        private void FileBtn_Click(object sender, EventArgs e)
        {
            string partName = PartNameField.Text;
            int incomingStock = Convert.ToInt32(StockField.Text);

            int col = Convert.ToInt32(colField.Text);
            int row = Convert.ToInt32(RowField.Text);
            int bracket = Convert.ToInt32(BracketField.Text);
            int compartment = ((row - 1) * 24) + (col - 1) * 6 + bracket; //rekesz = ((Sor-1)*24)+(Oszlop-1)*6+polc
            CompartmentField.Text = compartment.ToString();

            //Az alkatreszek tábla ellenőrzése, hogy megtalálhatóe a táblában a bejövő alkatrész
            con.Open();
            command = new MySqlCommand("SELECT COUNT(*) FROM alkatreszek WHERE ANev = @PartName", con);
            command.Parameters.AddWithValue("@PartName", partName);
            int partCounter = Convert.ToInt32(command.ExecuteScalar());
            con.Close();

            if (partCounter == 0)
            {
                MessageBox.Show("Az alkatresz nem szerepel a nyilvántartásban, kérem előbb vezesse fel az ~alkatreszek~ táblában.");
            }
            else
            {
                con.Open();
                command = new MySqlCommand("SELECT COUNT(*) FROM raktar WHERE Alkatresz = @PartName", con);
                command.Parameters.AddWithValue("@PartName", partName);
                int count = Convert.ToInt32(command.ExecuteScalar());
                con.Close();

                if (count > 0) //Van már az alkatrészből a raktárban
                {
                    con.Open();
                    //A raktárban lévő darabszám 
                    command = new MySqlCommand("SELECT Darab FROM raktar WHERE Alkatresz = @PartName", con);
                    command.Parameters.AddWithValue("@PartName", partName);
                    int storagedStock = Convert.ToInt32(command.ExecuteScalar());
                    //idáig tuti jó.
                    //a maximális darabszám lekérése az alkatreszek táblából, az összehasonlításhoz.
                    command = new MySqlCommand("SELECT Maxdb FROM  alkatreszek WHERE ANev = @PartName", con);
                    command.Parameters.AddWithValue("@PartName", partName);
                    int maxStock = Convert.ToInt32(command.ExecuteScalar());

                    int allIncStock = storagedStock + incomingStock;

                    if (allIncStock < maxStock) // fér még a rekeszbe
                    {
                        command = new MySqlCommand("UPDATE raktar SET Darab = @allinc WHERE Alkatresz = @ANev", con);
                        command.Parameters.AddWithValue("@allinc", allIncStock);
                        command.Parameters.AddWithValue("@ANev", partName);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Az alkatrész mennyiség hozzáadva a rekeszben tárolthoz.");
                    }
                    else //nem fér a rekeszbe
                    {
                        int toMuchStock = storagedStock + incomingStock - maxStock;
                        MessageBox.Show("A megadott mennyiség meghaladja a maximális határt, ennyivel: " + toMuchStock.ToString());
                        int modifiedCompartment = compartment + 1;

                        if ((modifiedCompartment - compartment) > 3 || ((modifiedCompartment - compartment) * maxStock < incomingStock))
                        {
                            MessageBox.Show("Az alkatrész már több mint 3 rekeszt foglalna, kérem helyezze el pótrekeszben.");
                        }
                        else
                        {
                            //Betelt a rekesz, de 3 rekesznél még nem foglal többet az alkatrész
                            command = new MySqlCommand("INSERT INTO raktar(Rekesz, Sor, Oszlop, Polc, Alkatresz, Darab) VALUES (@Compartment, @Row, @Col, @Bracket, @PartName, @Stock)", con);
                            command.Parameters.AddWithValue("@Compartment", modifiedCompartment);
                            command.Parameters.AddWithValue("@Row", row);
                            command.Parameters.AddWithValue("@Col", col);
                            command.Parameters.AddWithValue("@Bracket", bracket);
                            command.Parameters.AddWithValue("@PartName", partName);
                            command.Parameters.AddWithValue("@Stock", incomingStock);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Az alkatrész tárolva a" + modifiedCompartment.ToString() + ". rekeszbe.");
                        }
                    }
                    con.Close();
                }
                else
                {
                    con.Open();
                    //Nincs a raktárban és újonnan elraktározzuk
                    command = new MySqlCommand("INSERT INTO raktar(Rekesz, Sor, Oszlop, Polc, Alkatresz, Darab) VALUES (@Compartment, @Row, @Col, @Bracket, @PartName, @Stock)", con);
                    command.Parameters.AddWithValue("@Compartment", compartment);
                    command.Parameters.AddWithValue("@Row", row);
                    command.Parameters.AddWithValue("@Col", col);
                    command.Parameters.AddWithValue("@Bracket", bracket);
                    command.Parameters.AddWithValue("@PartName", partName);
                    command.Parameters.AddWithValue("@Stock", incomingStock);
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Az alkatrész hozzáadta a raktár táblához.");
                }

            }
        }


        private void ListBtn_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
