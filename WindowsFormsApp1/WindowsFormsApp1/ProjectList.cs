using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;

namespace WindowsFormsApp1
{
    public partial class ProjectList : Form
    {
        private readonly string conn = @"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem";
        private readonly string query = "SELECT * FROM Projekt";
        private string seged;

        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public ProjectList()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            projectListGrid.AutoGenerateColumns = false;
            projectListGrid.Columns[0].Name = "ProjektKod";
            projectListGrid.Columns[0].HeaderText = "ProjektKod";
            projectListGrid.Columns[0].DataPropertyName = "ProjektKod";
            projectListGrid.Columns[1].Name = "Helyszin";
            projectListGrid.Columns[1].HeaderText = "Helyszin";
            projectListGrid.Columns[1].DataPropertyName = "Helyszin";
            projectListGrid.Columns[2].Name = "Leiras";
            projectListGrid.Columns[2].HeaderText = "Leiras";
            projectListGrid.Columns[2].DataPropertyName = "Leiras";
            projectListGrid.Columns[3].Name = "Statusz";
            projectListGrid.Columns[3].HeaderText = "Statusz";
            projectListGrid.Columns[3].DataPropertyName = "Statusz";
            try
            {
                con = new MySqlConnection(conn);
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM Projekt", con);
                adapter = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adapter.Fill(table);
                projectListGrid.DataSource = table;
                projectListGrid.Refresh();
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

        private void button1_Click(object sender, EventArgs e) => projectListGrid.DataSource = GetProjects();

        private DataTable GetProjects()
        {
            DataTable dtProj = new DataTable();

            using (var con = new MySqlConnection(conn))
            {
                using (var cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    var dr = cmd.ExecuteReader();
                    dtProj.Load(dr);
                    LoadData();
                }
                con.Close();
            }

            return dtProj;
        }

        private void projectListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IsScheduledSelected(DataGridView dataGridView)
        {
            // Ellenőrizzük, hogy van-e kiválasztott sor
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Ellenőrizzük a kiválasztott sor negyedik oszlopát
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                string fourthColumnValue = selectedRow.Cells[3].Value.ToString();

                // Ellenőrizzük, hogy a negyedik oszlop értéke "Scheduled" szöveggel egyezik-e
                if (fourthColumnValue.Equals("Scheduled", StringComparison.OrdinalIgnoreCase))
                {
                    seged = selectedRow.Cells[0].Value.ToString();
                    try
                    {
                        con.Open();
                        cmd = new MySqlCommand("UPDATE Projekt SET statusz = 'InProgress' WHERE Projektkod = @Projektkod", con);
                        cmd.Parameters.AddWithValue("@Projektkod", seged);
                        cmd.ExecuteNonQuery();
                        // Frissítjük az adatokat a DataGridView-ban
                        LoadData();

                        MessageBox.Show("A státusz sikeresen módosítva lett, megkezdődhet a munka.");
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
                else
                {
                    MessageBox.Show("Ez nem Draft sor!");
                }
            }
            else
            {
                MessageBox.Show("Válassz ki egy sort!");
            };
        }

        private void CompletedProject(DataGridView dataGridView)
        {

            Form customMessageBox = new Form
            {
                Text = "Confirmation",
                Size = new System.Drawing.Size(300, 150),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent
            };

            // Add message label
            Label messageLabel = new Label
            {
                Text = "Biztos sikeresre állítod ezt a projektet?",
                AutoSize = true,
                Location = new System.Drawing.Point(30, 20)
            };
            customMessageBox.Controls.Add(messageLabel);

            // Add Yes button
            Button yesButton = new Button
            {
                Text = "Igen",
                DialogResult = DialogResult.Yes,
                Location = new System.Drawing.Point(50, 80)
            };
            customMessageBox.Controls.Add(yesButton);

            // Add No button
            Button noButton = new Button
            {
                Text = "Nem",
                DialogResult = DialogResult.No,
                Location = new System.Drawing.Point(150, 80)
            };
            customMessageBox.Controls.Add(noButton);

            // Set the form's AcceptButton and CancelButton properties
            customMessageBox.AcceptButton = yesButton;
            customMessageBox.CancelButton = noButton;
            DialogResult diaresult;

            // Ellenőrizzük, hogy van-e kiválasztott sor
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Ellenőrizzük a kiválasztott sor negyedik oszlopát
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                string fourthColumnValue = selectedRow.Cells[3].Value.ToString();

                // Ellenőrizzük, hogy a negyedik oszlop értéke "draft" szöveggel egyezik-e
                if (fourthColumnValue.Equals("inprogress", StringComparison.OrdinalIgnoreCase))
                {
                    seged = selectedRow.Cells[0].Value.ToString();
                    try
                    {
                        diaresult = customMessageBox.ShowDialog();
                        if (diaresult == DialogResult.Yes)
                        {
                            con.Open();
                            cmd = new MySqlCommand("UPDATE Projekt SET statusz = 'Completed' WHERE Projektkod = @Projektkod", con);
                            cmd.Parameters.AddWithValue("@Projektkod", seged);
                            cmd.ExecuteNonQuery();
                            // Frissítjük az adatokat a DataGridView-ban
                            LoadData();
                            MessageBox.Show("Státuszfrissítés jóváhagyva!");
                        }
                        else
                        {
                            MessageBox.Show("Státuszfrissítés elvetve!");
                        }

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
                else
                {
                    MessageBox.Show("Ezt a projektet nem lehet befejezni!");
                }
            }
            else
            {
                MessageBox.Show("Válassz ki egy sort!");
            };
        }

        private void FailedProject(DataGridView dataGridView)
        {

            Form customMessageBox = new Form
            {
                Text = "Confirmation",
                Size = new System.Drawing.Size(300, 150),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent
            };

            // Add message label
            Label messageLabel = new Label
            {
                Text = "Biztos sikertelenre állítod ezt a projektet?",
                AutoSize = true,
                Location = new System.Drawing.Point(30, 20)
            };
            customMessageBox.Controls.Add(messageLabel);

            // Add Yes button
            Button yesButton = new Button
            {
                Text = "Igen",
                DialogResult = DialogResult.Yes,
                Location = new System.Drawing.Point(50, 80)
            };
            customMessageBox.Controls.Add(yesButton);

            // Add No button
            Button noButton = new Button
            {
                Text = "Nem",
                DialogResult = DialogResult.No,
                Location = new System.Drawing.Point(150, 80)
            };
            customMessageBox.Controls.Add(noButton);

            // Set the form's AcceptButton and CancelButton properties
            customMessageBox.AcceptButton = yesButton;
            customMessageBox.CancelButton = noButton;
            DialogResult diaresult;

            // Ellenőrizzük, hogy van-e kiválasztott sor
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Ellenőrizzük a kiválasztott sor negyedik oszlopát
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                string fourthColumnValue = selectedRow.Cells[3].Value.ToString();
                if (!fourthColumnValue.Equals("completed", StringComparison.OrdinalIgnoreCase) || !fourthColumnValue.Equals("failed", StringComparison.OrdinalIgnoreCase))
                {
                    seged = selectedRow.Cells[0].Value.ToString();
                    try
                    {
                        diaresult = customMessageBox.ShowDialog();
                        if (diaresult == DialogResult.Yes)
                        {
                            con.Open();
                            cmd = new MySqlCommand("UPDATE Projekt SET statusz = 'Failed' WHERE Projektkod = @Projektkod", con);
                            cmd.Parameters.AddWithValue("@Projektkod", seged);
                            cmd.ExecuteNonQuery();
                            // Frissítjük az adatokat a DataGridView-ban
                            LoadData();
                            MessageBox.Show("Státuszfrissítés jóváhagyva!");
                        }
                        else
                        {
                            MessageBox.Show("Státuszfrissítés elvetve!");
                        }

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
                else
                {
                    MessageBox.Show("Nem végrahajtható a művelet!");
                }
            }
            else
            {
                MessageBox.Show("Válassz ki egy sort!");
            }
        }

        //InProgressre állítás
        private void button2_Click(object sender, EventArgs e) => IsScheduledSelected(projectListGrid);

        //Sikeres projekt
        private void button3_Click(object sender, EventArgs e) => CompletedProject(projectListGrid);

        //Sikertelen projekt
        private void button4_Click(object sender, EventArgs e) => FailedProject(projectListGrid);

        private void projectListGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}