using FarmerLibrary;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            if(Form2.number == 7)
            {
                label1.Location= new Point(146, 36);
                textBox1.Location = new Point(350, 45);
                textBox3.Visible = true;
                label3.Visible = true;
                textBox3.Text = "";
            }
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
                    x = Convert.ToInt32(n);
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
            if (Check(textBox1.Text) == true)
                switch (Form2.number)
                {
                    case 1:
                        textBox2.Text = Farmer.EquilateralTriangleArea(Convert.ToDouble(textBox1.Text)).ToString();
                        break;
                    case 2:
                        textBox2.Text = Farmer.RhombusArea(Convert.ToDouble(textBox1.Text)).ToString();
                        break;
                    case 3:
                        textBox2.Text = Farmer.RectangleArea(Convert.ToDouble(textBox1.Text)).ToString();
                        break;
                    case 4:
                        textBox2.Text = Farmer.SquareArea(Convert.ToDouble(textBox1.Text)).ToString();
                        break;
                    case 5:
                        textBox2.Text = Farmer.PentagonArea(Convert.ToDouble(textBox1.Text)).ToString();
                        break;
                    case 6:
                        textBox2.Text = Farmer.HexagonArea(Convert.ToDouble(textBox1.Text)).ToString();
                        break;
                    case 7:
                        if(Check_n(textBox3.Text))
                            textBox2.Text = Farmer.N_gonArea(Convert.ToDouble(textBox1.Text), Convert.ToInt32(textBox3.Text)).ToString();
                        break;
                    case 8:
                        textBox2.Text = Farmer.CircleArea(Convert.ToDouble(textBox1.Text)).ToString();
                        break;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            label3.Visible = false;
            textBox1.Height = 95;
            label1.Height = 86;
            textBox3.Text = "";
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }
    }
}
