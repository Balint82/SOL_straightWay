using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class ModifyPrices : Form
    {
        readonly MySqlConnection con;
        readonly MySqlCommand cmd;
        public ModifyPrices()
        {
            con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem");
            //cmd = new MySqlCommand("INSERT INTO Alkatreszek(ANev, Maxdb, Darab, Ar) VALUES (@ANev, @Maxdb, @Darab, @Ar)", con);
            cmd = new MySqlCommand("UPDATE Alkatreszek SET Ar = @Ar WHERE ANev = @ANev", con);
            InitializeComponent();
        }
        private void ModifyPriceBtn_Click(object sender, EventArgs e)      // Hozzáad
        {        
            cmd.Parameters.AddWithValue("@ANev", PartNameField.Text);    // Anev
            cmd.Parameters.AddWithValue("@Ar", PriceField.Text);      // Ár

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Az ármódosítás megtörtént.");
        }

        private void CancelBtn_Click(object sender, EventArgs e) => Close(); // Mégse

        private void PartNameLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
