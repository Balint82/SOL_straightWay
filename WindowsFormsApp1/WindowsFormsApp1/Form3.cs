using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

       

        private void AddProjectBtn_Click(object sender, EventArgs e) //Új project
        {
            AddProject ap = new AddProject();
            ap.Show();
        }

        private void ListProjectBtn_Click(object sender, EventArgs e) //
        {
            ProjectList pl = new ProjectList();
            pl.Show();
        }

        private void ListPartBtn_Click(object sender, EventArgs e)
        {
            Displaytest displaytest = new Displaytest();
            displaytest.Show();
        }

        private void ChoosedPartBtn_Click(object sender, EventArgs e)
        {
            PartToProject partToProject = new PartToProject();
            partToProject.Show();
        }

       

        private void PriceCalcBtn_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.Show();
        }

        

        private void button7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
