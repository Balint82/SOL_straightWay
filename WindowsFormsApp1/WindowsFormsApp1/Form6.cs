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
    public partial class Form6 : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            // DataGridView oszlopok beállítása
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns[0].Name = "ANev";
            datagrid.Columns[0].HeaderText = "Név";
            datagrid.Columns[0].DataPropertyName = "ANev";
            datagrid.Columns[1].Name = "Ar";
            datagrid.Columns[1].HeaderText = "Ár";
            datagrid.Columns[1].DataPropertyName = "Ar";
            datagrid.Columns[2].Name = "Szukdb";
            datagrid.Columns[2].HeaderText = "Szükséges db";
            datagrid.Columns[2].DataPropertyName = "Szukdb";
            datagrid.Columns[3].Name = "Darab";
            datagrid.Columns[3].HeaderText = "Darab";
            datagrid.Columns[3].DataPropertyName = "Darab";

            // Adatok betöltése DataGridView-be
            LoadData();
        }
        private void LoadData()
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns[0].Name = "ANev";
            datagrid.Columns[0].HeaderText = "Név";
            datagrid.Columns[0].DataPropertyName = "ANev";
            datagrid.Columns[1].Name = "Ar";
            datagrid.Columns[1].HeaderText = "Ár";
            datagrid.Columns[1].DataPropertyName = "Ar";
            datagrid.Columns[2].Name = "Szukdb";
            datagrid.Columns[2].HeaderText = "Szükséges db";
            datagrid.Columns[2].DataPropertyName = "Szukdb";
            datagrid.Columns[3].Name = "Darab";
            datagrid.Columns[3].HeaderText = "Darab";
            datagrid.Columns[3].DataPropertyName = "Darab";
            try
            {
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM projektraktar WHERE Projektkod EQUALS @Projekt", con);
                cmd.Parameters.AddWithValue("@Projekt", textBox2.Text);
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
        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
