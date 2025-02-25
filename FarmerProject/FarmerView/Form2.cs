using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerView
{
    public partial class Form2 : Form
    {
        public static byte number = 0;

        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            number = 1;
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = 2;
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number = 3;
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number = 4;
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number = 5;
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number = 6;
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number = 7;
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number = 8;
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
