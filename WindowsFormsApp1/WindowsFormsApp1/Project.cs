using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Project : Form
    {
        readonly MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;

        public Project()
        {
            InitializeComponent();
        }
        private void Projects_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Project_Load(object sender, EventArgs e)
        {
            LoadData();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            // DataGridView oszlopok beállítása
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns[0].Name = "ProjektKod";
            datagrid.Columns[0].HeaderText = "ProjektKod";
            datagrid.Columns[0].DataPropertyName = "ProjektKod";
            datagrid.Columns[1].Name = "Helyszin";
            datagrid.Columns[1].HeaderText = "Helyszin";
            datagrid.Columns[1].DataPropertyName = "Helyszin";
            datagrid.Columns[2].Name = "Leiras";
            datagrid.Columns[2].HeaderText = "Leiras";
            datagrid.Columns[2].DataPropertyName = "Leiras";
            datagrid.Columns[3].Name = "Statusz";
            datagrid.Columns[3].HeaderText = "Statusz";
            datagrid.Columns[3].DataPropertyName = "Statusz";

            // Adatok betöltése DataGridView-be
            LoadData();
        }

        private void label3_Click(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns[0].Name = "ProjektKod";
            datagrid.Columns[0].HeaderText = "ProjektKod";
            datagrid.Columns[0].DataPropertyName = "ProjektKod";
            datagrid.Columns[1].Name = "Helyszin";
            datagrid.Columns[1].HeaderText = "Helyszin";
            datagrid.Columns[1].DataPropertyName = "Helyszin";
            datagrid.Columns[2].Name = "Leiras";
            datagrid.Columns[2].HeaderText = "Leiras";
            datagrid.Columns[2].DataPropertyName = "Leiras";
            datagrid.Columns[3].Name = "Statusz";
            datagrid.Columns[3].HeaderText = "Statusz";
            datagrid.Columns[3].DataPropertyName = "Statusz";
            try
            {
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM Projekt", con);
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e) // Hozzáad
        {

            MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Projekt(ProjektKod,Helyszin,Leiras,Statusz) VALUES (@ProjektKod,@Helyszin, @Leiras, @Statusz)", con);

            cmd.Parameters.AddWithValue("@ProjektKod", textBox7.Text);
            cmd.Parameters.AddWithValue("@Helyszin", textBox2.Text);
            cmd.Parameters.AddWithValue("@Leiras", textBox3.Text);
            cmd.Parameters.AddWithValue("@Statusz", textBox5.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e) => datagrid.DataSource = GetList();

        private DataTable GetList()
        {
            DataTable dtProj = new DataTable();
            string conn = @"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";

            using (var con = new MySqlConnection(conn))
            {
                using (var cmd = new MySqlCommand("SELECT * FROM projektek", con))
                {
                    con.Open();
                    var dr = cmd.ExecuteReader();
                    dtProj.Load(dr);
                }
            }

            return dtProj;
        }
    }
}