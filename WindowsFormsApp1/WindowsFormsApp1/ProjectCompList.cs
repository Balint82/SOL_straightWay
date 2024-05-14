using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class ProjectCompList : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;

        private readonly string conn = @"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem";
        private readonly string query = "SELECT * FROM projektraktar";

        public ProjectCompList()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].Name = "ProjektKod";
            dataGridView1.Columns[0].HeaderText = "ProjektKod";
            dataGridView1.Columns[0].DataPropertyName = "ProjektKod";

            dataGridView1.Columns[1].Name = "ANev";
            dataGridView1.Columns[1].HeaderText = "ANev";
            dataGridView1.Columns[1].DataPropertyName = "ANev";

            dataGridView1.Columns[2].Name = "Sor";
            dataGridView1.Columns[2].HeaderText = "Sor";
            dataGridView1.Columns[2].DataPropertyName = "Sor";

            dataGridView1.Columns[3].Name = "Oszlop";
            dataGridView1.Columns[3].HeaderText = "Oszlop";
            dataGridView1.Columns[3].DataPropertyName = "Oszlop";

            dataGridView1.Columns[4].Name = "Polc";
            dataGridView1.Columns[4].HeaderText = "Polc";
            dataGridView1.Columns[4].DataPropertyName = "Polc";

            dataGridView1.Columns[5].Name = "Rekesz";
            dataGridView1.Columns[5].HeaderText = "Rekesz";
            dataGridView1.Columns[5].DataPropertyName = "Rekesz";

            dataGridView1.Columns[6].Name = "Darab";
            dataGridView1.Columns[6].HeaderText = "Darab";
            dataGridView1.Columns[6].DataPropertyName = "Darab";


            try
            {
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM projektraktar INNER JOIN raktar ON projektraktar.ANev = raktar.Alkatresz", con);
                adapter = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Refresh();
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

        private void ListCompBtn_Click(object sender, EventArgs e) => GetProjCompList();

        private DataTable GetProjCompList()
        {
           
            DataTable dt = new DataTable();
            using (var con = new MySqlConnection(conn))
            {
                using (var cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    var dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    LoadData();
                }
            }

            return dt;
        }
    }
}
