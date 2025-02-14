using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FarmerLibrary;

namespace FarmerView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Check(string p)
        {
            if (p.Length == 0)
            {
                textBox2.Text = "Введите периметр!".ToString();
                return false;
            }
            else
            {
                double x;
                try
                {
                    x = Convert.ToDouble(p);
                }
                catch (Exception)
                {
                    textBox2.Text = "Введите число!".ToString();
                    return false;
                }
                if (x < 0)
                {
                    textBox2.Text = "Периметр < 0!".ToString();
                    return false;
                }
                else return true;
            }
        }

        bool Check_n(string n)
        {
            if (n.Length == 0)
            {
                textBox2.Text = "Введите количество сторон!".ToString();
                return false;
            }
            else
            {
                double x;
                try
                {
                    x = Convert.ToDouble(n);
                }
                catch (Exception)
                {
                    textBox2.Text = "Введите число!".ToString();
                    return false;
                }
                if (x < 3)
                {
                    textBox2.Text = "Количество сторон < 3!".ToString();
                    return false;
                }
                else return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            if (Check(p) == true)
                textBox2.Text = Farmer.EquilateralTriangleArea(Convert.ToDouble(p)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            if (Check(p) == true) 
                textBox2.Text = Farmer.SquareArea(Convert.ToDouble(p)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            if (Check(p) == true)
                textBox2.Text = Farmer.RhombusArea(Convert.ToDouble(p)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            if (Check(p) == true)
                textBox2.Text = Farmer.RectangleArea(Convert.ToDouble(p)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            if (Check(p) == true)
                textBox2.Text = Farmer.PentagonArea(Convert.ToDouble(p)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            if (Check(p) == true)
                textBox2.Text = Farmer.HexagonArea(Convert.ToDouble(p)).ToString();
        }

        private double button7_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            if (Check(p) == true)
            {
                textBox3.Visible = true;
                button9.Visible = true;
                return Convert.ToDouble(p);
            }
            return 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string p = textBox1.Text;
            if (Check(p) == true)
                textBox2.Text = Farmer.CircleArea(Convert.ToDouble(p)).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string n = textBox3.Text;
            if (Check_n(n) == true)
            {
                textBox2.Text = Farmer.N_gonArea(button7_Click(sender, e), Convert.ToInt32(n)).ToString();
                textBox3.Visible = false;
                button9.Visible = false;
                textBox3.Text = "";
            }
        }
    }
}
