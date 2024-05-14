using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable table;

        public Form4()
        {
            InitializeComponent();
        }
        private void Forms4_Load(object sender, EventArgs e)
        {
        }
       
        private void Form4_Load(object sender, EventArgs e)
        {          
        }
        
        private void ListPriceAndTime_Click(object sender, EventArgs e) => LoadData();
        
        private void LoadData()
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns[0].Name = "ProjectID";
            datagrid.Columns[0].HeaderText = "ProjectID";
            datagrid.Columns[0].DataPropertyName = "ProjectID";

            datagrid.Columns[1].Name = "Munkaora";
            datagrid.Columns[1].HeaderText = "Munkaóra";
            datagrid.Columns[1].DataPropertyName = "Munkaora";

            datagrid.Columns[2].Name = "Munkadij";
            datagrid.Columns[2].HeaderText = "Munkadíj";
            datagrid.Columns[2].DataPropertyName = "Munkadij";

            datagrid.Columns[3].Name = "Arkalkulacio";
            datagrid.Columns[3].HeaderText = "Arkalkulacio";
            datagrid.Columns[3].DataPropertyName = "Arkalkulacio";

            datagrid.Columns[4].Name = "NettoAr";
            datagrid.Columns[4].HeaderText = "Nettó Ár";
            datagrid.Columns[4].DataPropertyName = "NettoAr";


            try
            {
                con.Open();
                cmd = new MySqlCommand("SELECT ProjectID, Munkaora, Munkadij, Munkaora * Munkadij AS Arkalkulacio, NettoAr FROM Arkalkulacio", con);
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

        private void IsWait(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                string firstColumnValue = selectedRow.Cells[0].Value.ToString();
              
                try
                {
                    con.Open();
                    cmd = new MySqlCommand("SELECT statusz FROM Projekt WHERE Projektkod = @Projektkod", con);
                    cmd.Parameters.AddWithValue("@Projektkod", firstColumnValue);
                    string status = Convert.ToString(cmd.ExecuteScalar());
                    con.Close();

                    if (status == "Wait")
                    {
                        /*
                        double nettoAr = Convert.ToDouble(selectedRow.Cells[1].Value) * Convert.ToDouble(selectedRow.Cells[2].Value);                      
                        con.Open() ;
                        cmd = new MySqlCommand("UPDATE arkalkulacio SET NettoAr = @NettoAr", con);
                        cmd.Parameters.AddWithValue("@NettoAr", nettoAr);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        */
                        con.Open();
                        // SQL parancs létrehozása az árkalkuláció frissítésére                                     

                        
                        string sqlQuery = @"SELECT 
                                                                SUM(al.Ar * prt.SzDarab) AS NettoAr 
                                                            FROM 
                                                                projektraktar prt
                                                            JOIN 
                                                                alkatreszek al ON prt.ANev = al.ANev
                                                            WHERE 
                                                                prt.ProjektKod = @ProjektKod
                                                            GROUP BY 
                                                                prt.ProjektKod";
                        

                        cmd = new MySqlCommand(sqlQuery, con);
                        cmd.Parameters.AddWithValue("@ProjektKod", firstColumnValue);
                        double result = Convert.ToDouble(cmd.ExecuteScalar());
                        Console.WriteLine(result);
                        con.Close();
                        UpdateNettoAr(firstColumnValue, result);

                        con.Open();
                        string statusQuery = @"UPDATE Projekt SET Statusz = 'Scheduled' WHERE ProjektKod = @ProjektKod";
                        cmd = new MySqlCommand(statusQuery, con);
                        cmd.Parameters.AddWithValue("@ProjektKod", firstColumnValue);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Az árkalkuláció megtörtént és a státusz frissítve lett.");
                    }
                    else
                    {
                        MessageBox.Show("Ennek a projektnek a státusza nem Wait!");
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
                MessageBox.Show("Válassz ki egy sort!");
            }
        }



        private void UpdateNettoAr(string projectID, double nettoAr)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand("UPDATE Arkalkulacio SET NettoAr = @NettoAr WHERE ProjectID = @ProjectID", con);
                cmd.Parameters.AddWithValue("@NettoAr", nettoAr);
                cmd.Parameters.AddWithValue("@ProjectID", projectID);
                cmd.ExecuteNonQuery();
                con.Close();

                LoadData(); // Frissítsd a DataGridView-t az új adatokkal
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok frissítése közben: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void WorkTimeField_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkPriceField_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectIDField_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalcPriceBtn_Click(object sender, EventArgs e)
        {
            IsWait(datagrid);
        }
    }
}
