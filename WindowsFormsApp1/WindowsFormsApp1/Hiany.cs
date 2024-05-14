using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Hiany : Form
    {
        string conn = @"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem";
        public Hiany()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => miss_occ_datagrid.DataSource = GetMissingList();

        // B.3
        private DataTable GetMissingList()
        {
            DataTable dtMissing = new DataTable();
            string query = "Select * from hianyzoalkatreszek where hiany_statusz like 'hiányzik'";

            using (var con = new MySqlConnection(conn))
            {
                using (var cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    var dr = cmd.ExecuteReader();
                    dtMissing.Load(dr);
                }
            }

            return dtMissing;
        }

        private void button2_Click(object sender, EventArgs e) => miss_occ_datagrid.DataSource = GetOccupiedList();

        // B.4
        private DataTable GetOccupiedList()
        {
            DataTable dtOcc = new DataTable();

      
            string query = "Select * from hianyzoalkatreszek where hiany_statusz like 'lefoglalva';";

            using (var con = new MySqlConnection(conn))
            {
                using (var cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    var dr = cmd.ExecuteReader();
                    dtOcc.Load(dr);
                }
            }

            return dtOcc;
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = miss_occ_datagrid.SelectedRows[0];
            string firstColumnValue = selectedRow.Cells[0].Value.ToString();
            try
            {
                var con = new MySqlConnection(conn);
                con.Open();
                MySqlCommand query = new MySqlCommand("UPDATE hianyzoalkatreszek SET hiany_statusz = 'lefoglalva' WHERE hiany_nev=@hiany_nev", con);
                query.Parameters.AddWithValue("@hiany_nev", firstColumnValue);
                query.ExecuteNonQuery();
                MessageBox.Show($"{firstColumnValue} lefoglalva");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok betöltése közben: " + ex.Message);
            }
        }
    }
}
