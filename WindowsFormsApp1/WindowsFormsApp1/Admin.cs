using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        string conn = @"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem";
        string query = "INSERT INTO felhasznalok(Felhasznalonev, Jelszo, Beosztas) VALUES (@Felhasznalonev, @Jelszo, @Beosztas)";

        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = new MySqlConnection(conn))
                {
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Felhasznalonev", textBox5.Text);
                        cmd.Parameters.AddWithValue("@Jelszo", HashPWD(textBox2.Text));
                        cmd.Parameters.AddWithValue("@Beosztas", textBox4.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba a beszúrás során: {ex}");
            }
        }

        private string HashPWD(string pwd)
        {
            using(var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pwd));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void Check()
        {
            bool isHidden = textBox5.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox4.Text.Trim() != "";
            button2.Visible = isHidden;
        }
    }
}
