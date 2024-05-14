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
using Mysqlx.Connection;
using MySqlX.XDevAPI.Relational;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;


        public Form5()
        {
            InitializeComponent();
        }
        private void Displaytest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'napelemDataSet.Components' table. You can move, or remove it, as needed.

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGridView oszlopok beállítása
            datagrid.AutoGenerateColumns = false;
            datagrid.ColumnCount = 3;
            datagrid.Columns[0].Name = "Projekt";
            datagrid.Columns[0].HeaderText = "Projekt";
            datagrid.Columns[0].DataPropertyName = "Projekt";
            datagrid.Columns[1].Name = "Alkatrész";
            datagrid.Columns[1].HeaderText = "Alkatresz";
            datagrid.Columns[1].DataPropertyName = "Alkatresz";
            datagrid.Columns[2].Name = "Darab";
            datagrid.Columns[2].HeaderText = "Darab";
            datagrid.Columns[2].DataPropertyName = "Darab";
            // Adatok betöltése DataGridView-be
            LoadData();
        }


        private void button2_Click(object sender, EventArgs e)      //Listáz
        {
            LoadData();
        }

        private void LoadData()
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns[0].Name = "Projekt";
            datagrid.Columns[0].HeaderText = "Projekt";
            datagrid.Columns[0].DataPropertyName = "Projekt";
            datagrid.Columns[1].Name = "Alkatrész";
            datagrid.Columns[1].HeaderText = "Alkatresz";
            datagrid.Columns[1].DataPropertyName = "Alkatresz";
            datagrid.Columns[2].Name = "Darab";
            datagrid.Columns[2].HeaderText = "Darab";
            datagrid.Columns[2].DataPropertyName = "Darab";
            try
            {
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM projektraktar", con);
                adapter = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adapter.Fill(table);
                datagrid.DataSource = table;
                datagrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok betöltése közben: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)      //Hozzáad
        {

            MySqlCommand cmd = new MySqlCommand("INSERT INTO projektraktar(ProjektKod, ANev, Szdb) VALUES (@projekt, @alkatresz, @Darab)", con);
            cmd.Parameters.AddWithValue("@projekt", textBox2.Text);
            cmd.Parameters.AddWithValue("@alkatresz", textBox3.Text);
            cmd.Parameters.AddWithValue("@Darab", textBox5.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void runQuery()
        {
            //MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Alkatreszek(ANev, Maxdb, Darab, Ar) VALUES (@ANev, @Maxdb, @Darab, @Ar)", con);

            cmd.Parameters.AddWithValue("@ANev", textBox2.Text);    //Anev
            cmd.Parameters.AddWithValue("@Maxdb", textBox3.Text);   //Maxdb
            cmd.Parameters.AddWithValue("@Darab", textBox5.Text);   //Db
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO projektraktar(ProjektKod, ANev, Szdb) VALUES (@projekt, @alkatresz, @Darab)", con);
            cmd.Parameters.AddWithValue("@projekt", textBox2.Text);
            cmd.Parameters.AddWithValue("@alkatresz", textBox3.Text);
            cmd.Parameters.AddWithValue("@Darab", textBox5.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

