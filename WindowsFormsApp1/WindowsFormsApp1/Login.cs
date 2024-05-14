using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        // Idő alapú kizárás

        private int loginFail = 0;
        private DateTime lockoutEnd;

        // Segédfüggvények

        bool AuthUser(string user, string pwd)
        {
            bool yes = false;

            string hashPWD = HashPWD(pwd);
            string conn = @"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem";
            string query = "SELECT Jelszo, Beosztas FROM felhasznalok WHERE Felhasznalonev = @Felhasznalonev";

            try
            {
                using (var con = new MySqlConnection(conn))
                {
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Felhasznalonev", user);
                        con.Open();
                        var dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            string storedHashPWD = dr["Jelszo"].ToString();
                            string mastery = dr["Beosztas"].ToString();

                            yes = hashPWD.Equals(storedHashPWD);
                            if (yes)
                            {
                                // beosztás alapú felhatalmazási rendszer
                                if (mastery.Equals("raktárvezető"))
                                {
                                    Hide();
                                    Form1 f1 = new Form1();
                                    f1.Show();
                                }
                                if (mastery.Equals("raktáros"))
                                {
                                    Hide();
                                    Form2 f2 = new Form2();
                                    f2.Show();
                                }
                                if (mastery.Equals("szakember"))
                                {
                                    Hide();
                                    Form3 f3 = new Form3();
                                    f3.Show();
                                }
                                if (mastery.Equals("admin"))
                                {
                                    Hide();
                                    Admin ad = new Admin();
                                    ad.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hibás bejelentkezési adatok");
                            }
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Hiba a kapcsolat létesítésekor: {e}");
                yes = false;
            }
            return yes;
        }

        private string HashPWD(string pwd)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pwd));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private void InitiateLogin(string user, string pwd)
        {
            if (DateTime.Now < lockoutEnd)
            {
                MessageBox.Show($"Jelenleg ki van zárva! Kérem próbálja újra {lockoutEnd.Minute - DateTime.Now.Minute} múlva!");
                return;
            }

            if (AuthUser(user, pwd)) loginFail = 0;
            else
            {
                loginFail++;
                if (loginFail >= 3)
                {
                    int min = 5;
                    lockoutEnd = DateTime.Now.AddMinutes(min);
                    MessageBox.Show($"Maximális bejelentkezési próbálkozások száma elérve! Ki van zárva {min} percre!");
                }
                else MessageBox.Show("Helytelen bejelentkezési adat(ok)!");
            }
        }

        // Form-hoz kapcsolódó dolgok
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }


        private void LoginButtonClick(object sender, EventArgs e) => InitiateLogin(textBox1.Text, textBox2.Text);

        private void ExitButtonClick(object sender, EventArgs e) => Environment.Exit(0);
    }
}
