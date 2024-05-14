using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


//Raktáros menü

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private MySqlConnection conn;
        private const string conn_str =
            @"datasource=127.0.0.1;port=3306;username=root;password=orion;database=napelem";

        public Form2()
        {
            InitializeComponent();
            InitializeDBConn();
        }

        private void InitializeDBConn()
        {
            try
            {
                conn = new MySqlConnection(conn_str);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Sikertelen csatlakozás az adatbázishoz: {e}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectList pl = new ProjectList();
            pl.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjectCompList pcl = new ProjectCompList();
            pcl.Show();
        }

        private void OptButton_Click(object sender, EventArgs e)
        {
            Optimizer opt = new Optimizer();
            opt.InitAdjMat();

            Optimizer.Cell start = new Optimizer.Cell(0, 0, 0);
            Optimizer.Cell end = new Optimizer.Cell(9, 3, 5);

            List<Optimizer.Cell> sPath = opt.FindShortestPath(start, end);

            foreach (var cell in sPath)
            {
                InsertIntoDB(cell.Row, cell.Column, cell.Level);
            }
        }

        private void InsertIntoDB(int r, int c, int l)
        {
            try
            {
                string query = "INSERT INTO Raktar(Sor, Oszlop, Polc) VALUES (@r, @c, @l)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@r", r);
                cmd.Parameters.AddWithValue("@c", c);
                cmd.Parameters.AddWithValue("@l", l);
                cmd.ExecuteNonQuery();
            } catch(Exception e)
            {
                MessageBox.Show($"Hiba a táblába való beszúrás során: {e}");
            }
        }

    }
}
