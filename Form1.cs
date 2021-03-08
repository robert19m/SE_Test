using System;
using System.Windows.Forms;

namespace SE_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Is it home time yet!!!!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Lets see if this works!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Hopefully this will too!";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Mitko got it right!";
        }
    }
}
