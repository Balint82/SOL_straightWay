using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class PartToProject : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem");
        MySqlCommand command;
        MySqlDataAdapter adapter;

        public PartToProject()
        {
            InitializeComponent();
        }

        private void PartToProject_Load(object sender, EventArgs e)
        {
            // Itt helyezheted el az adatbázis kapcsolatot és az adatok lekérdezését
           
            con.Open();
            command = new MySqlCommand("SELECT ANev FROM alkatreszek", con);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string itemName = reader["ANev"].ToString();
                        PartComboBox.Items.Add(itemName);
                    }
                }
                else
                {
                    PartComboBox.Text = "Nincs találat az adatbázisban.";
                }
            }
            con.Close();
        }
        

        private void AddBtn_Click(object sender, EventArgs e)
        {         
            // Van e választott alkatrész a PartCombobox-ból
            if (PartComboBox.SelectedItem != null && !string.IsNullOrWhiteSpace(StockField.Text))
            {
                // Kiválasztott alkatrész neve
                string selectedPart = PartComboBox.SelectedItem.ToString();
                string projectIDInput = ProjectIDField.Text;
                

                // Megadott darabszám
                int quantity;
                if (!int.TryParse(StockField.Text, out quantity))
                {
                    MessageBox.Show("Kérlek adj meg egy érvényes darabszámot!");
                    return;
                }

                // Van-e elegendő raktárkészlet
                int currentStock;
                con.Open();
                    command = new MySqlCommand("SELECT Darab FROM raktar WHERE Alkatresz = @Alkatresz", con);
                    command.Parameters.AddWithValue("@Alkatresz", selectedPart);
                    currentStock = Convert.ToInt32(command.ExecuteScalar());
                con.Close() ;
                // Ha van elegendő raktárkészlet, frissítjük a projektraktárban az alkatrész mennyiségét
                if (currentStock >= quantity)
                {

                    con.Open();                      
                        command = new MySqlCommand("INSERT INTO projektraktar(ProjektKod, ANev, SzDarab) VALUES(@ProjectID, @ANev, @SZDarab)", con);                       
                        command.Parameters.AddWithValue("@ProjectID", projectIDInput);
                        command.Parameters.AddWithValue("@ANev", selectedPart);
                        command.Parameters.AddWithValue("@SZDarab", quantity);        
                        command.ExecuteNonQuery();       
                    con.Close();
                    //Javítási lehetőség feltétellel megnézi van-e már ilyen alkatrész adott projekt kódon a COUNT-tal és ott lehet neki if-et adni INSERT-re vagy UPDATE-re hogy ne akadjon ki ha esetleg ismételt hozzáadás történik a projektraktárhoz ugyanabból az alkatrészből
                 
                    
                    // Levonjuk az alkatrész kiválasztott mennyiségét az adatbázisból
                    con.Open();                  
                        command = new MySqlCommand("UPDATE raktar SET Darab = Darab - @quantity WHERE Alkatresz = @Alkatresz", con);            
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@Alkatresz", selectedPart);
                        command.ExecuteNonQuery();                                            
                    con.Close();

                    con.Open();
                    command = new MySqlCommand("UPDATE projekt SET Statusz = 'Draft' WHERE ProjektKod = @ProjectID", con);
                    command.Parameters.AddWithValue("@ProjectID", projectIDInput);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@ANev", selectedPart);
                    command.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("A projektraktárba áthelyezés megtörtént.");
                    // Hozzáadjuk az információkat a PartListBox-hoz
                    PartsListBox.Items.Add($"{selectedPart}: {quantity} darab");
                }
                else
                {
                    // Ha nincs elegendő raktárkészlet, küldünk egy üzenetet az InfoLog TextBox-ba
                    InfoLogTextbox.AppendText($"Nincs elegendő készlet: {currentStock} darab van a raktárban.");
                }
                
            }
            else
            {
                MessageBox.Show("Kérlek válassz ki egy alkatrészt és adj meg egy darabszámot!");
            }
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            command = new MySqlCommand("SELECT COUNT(*) FROM ProjektRaktar WHERE Projektkod = @Projektkod", con);
            command.Parameters.AddWithValue("@Projektkod", ProjectIDField.Text);
            int rowCount = Convert.ToInt32(command.ExecuteScalar());
            con.Close();


            if(rowCount >= 5)
            {
                con.Open();
                command = new MySqlCommand("UPDATE projekt SET Statusz = 'Wait' WHERE ProjektKod = @ProjectID", con);
                command.Parameters.AddWithValue("@ProjectID", ProjectIDField.Text);
                command.ExecuteNonQuery();
                con.Close();

                InfoLogTextbox.Clear();
                InfoLogTextbox.AppendText("A projekt Wait státuszba került.");
            }
            else
            {
                string connectionString = @"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem";
                string projectID = ProjectIDField.Text;

                List<List<object>> requiredParts = new List<List<object>>
                {
                    new List<object> { projectID, "AC csatlakozó", 2.0 },
                    new List<object> { projectID, "DC csatlakozó", 2.0 },
                    new List<object> { projectID, "Inverter", 2.0 },
                    new List<object> { projectID, "Napelem", 3.0 },
                    new List<object> { projectID, "Tartószerkezet", 5.0 }
                };

                List<Tuple<string, double, double>> missingParts = GetMissingParts(connectionString, projectID, requiredParts);

                if (missingParts.Count > 0)
                {
                    InsertMissingParts(connectionString, missingParts);
                }

                UpdateProjectStatus(connectionString, projectID, "Wait");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void stockField_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoLogTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectIDField_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        static List<Tuple<string, double, double>> GetMissingParts(string connectionString, string projectID, List<List<object>> requiredParts)
        {
            List<Tuple<string, double, double>> missingParts = new List<Tuple<string, double, double>>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT ANev, SzDarab FROM projektraktar WHERE ProjektKod = @ProjectID";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ProjectID", projectID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        Dictionary<string, double> availableParts = new Dictionary<string, double>();

                        while (reader.Read())
                        {
                            string partName = reader.GetString("ANev");
                            double quantity = reader.GetDouble("SzDarab");

                            if (!availableParts.ContainsKey(partName))
                            {
                                availableParts[partName] = quantity;
                            }
                        }

                        foreach (var requiredPart in requiredParts)
                        {
                            string partName = (string)requiredPart[1];
                            double requiredQuantity = (double)requiredPart[2];

                            if (!availableParts.ContainsKey(partName) || availableParts[partName] < requiredQuantity)
                            {
                                double missingQuantity = requiredQuantity - (availableParts.ContainsKey(partName) ? availableParts[partName] : 0);
                                double price = GetPartPrice(connectionString, partName);
                                missingParts.Add(new Tuple<string, double, double>(partName, missingQuantity, price));
                            }
                        }
                    }
                }
            }

            return missingParts;
        }

        static double GetPartPrice(string connectionString, string partName)
        {
            double price = 0.0;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT Ar FROM alkatreszek WHERE ANev = @PartName";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@PartName", partName);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        price = Convert.ToDouble(result);
                    }
                }
            }

            return price;
        }

        static void InsertMissingParts(string connectionString, List<Tuple<string, double, double>> missingParts)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = "INSERT INTO hianyzoalkatreszek (hiany_nev, hiany_db, hiany_ar, hiany_statusz) VALUES (@PartName, @Quantity, @Price, @Status)";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    foreach (var part in missingParts)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@PartName", part.Item1);
                        command.Parameters.AddWithValue("@Quantity", part.Item2);
                        command.Parameters.AddWithValue("@Price", part.Item3);
                        command.Parameters.AddWithValue("@Status", "hiányzik");

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        static void UpdateProjectStatus(string connectionString, string projectID, string status)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = "UPDATE projekt SET Statusz = @Status WHERE ProjektKod = @ProjectID";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ProjectID", projectID);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}


/* Javítási lehetőség
 try
        {
            // Ellenőrizzük, hogy létezik-e már ilyen rekord
            command = new MySqlCommand("SELECT COUNT(*) FROM projektraktar WHERE ProjektKod = @ProjectID AND ANev = @ANev", con);
            command.Parameters.AddWithValue("@ProjectID", projectIDInput);
            command.Parameters.AddWithValue("@ANev", selectedPart);
            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count > 0)
            {
                // Frissítjük a darabszámot
                command = new MySqlCommand("UPDATE projektraktar SET SzDarab = SzDarab + @Quantity WHERE ProjektKod = @ProjectID AND ANev = @ANev", con, tran);
                command.Parameters.AddWithValue("@Quantity", quantity);
            }
            else
            {
                // Beszúrjuk az új rekordot
                command = new MySqlCommand("INSERT INTO projektraktar (ProjektKod, ANev, SzDarab) VALUES (@ProjectID, @ANev, @Quantity)", con, tran);
                command.Parameters.AddWithValue("@Quantity", quantity);
            }

            command.Parameters.AddWithValue("@ProjectID", projectIDInput);
            command.Parameters.AddWithValue("@ANev", selectedPart);
            command.ExecuteNonQuery();

 */