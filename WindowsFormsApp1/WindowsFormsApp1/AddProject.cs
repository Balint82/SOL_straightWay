using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
            HideExecButton();

            CustomerEmailLabel.TextAlign = HorizontalAlignment.Right;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string conn = @"datasource=127.0.0.1;port=3306;username=root;password=;database=napelem";
            string query = "INSERT INTO Projekt(ProjektKod, Helyszin, Leiras, Statusz) VALUES (@ProjektKod, @Helyszin, @Leiras, @Statusz)";
            string customerQuery = "INSERT INTO megrendelo(MegrendeloID, ProjektKod, MegrendeloNev, MegrendeloEmail) VALUES(@MegrendeloID, @ProjektKod, @MegrendeloNev, @MegrendeloEmail)";
            string priceCalcQuery = "INSERT INTO arkalkulacio(ProjectID,Munkaora,Munkadij) VALUES (@ProjectID,@Munkaora, @Munkadij)";


            using (var con = new MySqlConnection(conn))
            {
                using(var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProjektKod", ProjectIDField.Text);
                    cmd.Parameters.AddWithValue("@Helyszin", LocationField.Text);
                    cmd.Parameters.AddWithValue("@Leiras", DescField.Text);
                    cmd.Parameters.AddWithValue("@Statusz", "InProgress");

                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0) 
                    {
                        DialogResult = DialogResult.OK;
                    }
                    con.Close();
                }

                using (var cmd = new MySqlCommand(customerQuery, con))
                {
                    cmd.Parameters.AddWithValue("@MegrendeloID", CustomerIDField.Text);
                    cmd.Parameters.AddWithValue("@ProjektKod", ProjectIDField.Text);
                    cmd.Parameters.AddWithValue("@MegrendeloNev", CustomerNameField.Text);
                    cmd.Parameters.AddWithValue("@MegrendeloEmail", CustomerEmailField.Text);

                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    con.Close();
                }

                using (var cmd = new MySqlCommand(priceCalcQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", ProjectIDField.Text);
                    cmd.Parameters.AddWithValue("@Munkaora", WorkTimeField.Text);
                    cmd.Parameters.AddWithValue("@Munkadij", WorkPriceField.Text);

                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    con.Close();
                }




            }
            MessageBox.Show("A projektet hozzáadta az adatbázishoz.");
        }

        private void HideExecButton()
        {
            CreateButton.Visible = false;
        }

        private void CustomerNameField_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void LocationField_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void DescField_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void Check()
        {
            bool allFilled = CustomerNameField.Text.Trim() != "" && LocationField.Text.Trim() != "" && DescField.Text.Trim() != "";
            CreateButton.Visible = allFilled;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerNameLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectIDLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerIDLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerEmailLabel_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void WorkHourLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkPriceLabel_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AddProject_Load(object sender, EventArgs e)
        {

        }
    }
}
