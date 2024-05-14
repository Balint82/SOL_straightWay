using System;
using System.Windows.Forms;

//Raktárvezető menü
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifyPrices mp = new ModifyPrices();
            mp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Displaytest addComponent = new Displaytest();
            addComponent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hiany h = new Hiany();
            h.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.Show();
        }

        private void IncomingStuffBtn_Click(object sender, EventArgs e)
        {
            IncomingPart incomingPart = new IncomingPart();
            incomingPart.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
