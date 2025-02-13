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

namespace FarmerView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void Circle_Box()
            {
                string p = textBox1.Text;
                double x;

                if (p.Length == 0)
                {
                    textBox8.Text = "Введите периметр!".ToString();
                    return;
                }

                else
                {
                    try
                    {
                        x = Convert.ToDouble(p);
                    }
                    catch (Exception)
                    {
                        textBox8.Text = "Введите число!".ToString();
                        return;
                    }

                    if (x < 0)
                    {
                        textBox8.Text = "Периметр < 0!".ToString();
                        return;
                    }

                    else
                    {
                        double radius = x / (2 * Math.PI);
                        textBox8.Text = (Math.PI * Math.Pow(radius, 2)).ToString();
                    }
                }
            }

            void Triangle_Box()
            {
                string p = textBox2.Text;
                double x;

                if (p.Length == 0)
                {
                    textBox9.Text = "Введите периметр!".ToString();
                    return;
                }

                else
                {
                    try
                    {
                        x = Convert.ToDouble(p);
                    }
                    catch (Exception)
                    {
                        textBox9.Text = "Введите число!".ToString();
                        return;
                    }

                    if (x < 0)
                    {
                        textBox9.Text = "Периметр < 0!".ToString();
                        return;
                    }

                    else
                    {
                        double side = x / 3;
                        textBox9.Text = ((Math.Sqrt(3) / 4) * Math.Pow(side, 2)).ToString();
                    }
                }
            }

            void Square_Box()
            {
                string p = textBox3.Text;
                double x;

                if (p.Length == 0)
                {
                    textBox10.Text = "Введите периметр!".ToString();
                    return;
                }

                else
                {
                    try
                    {
                        x = Convert.ToDouble(p);
                    }
                    catch (Exception)
                    {
                        textBox10.Text = "Введите число!".ToString();
                        return;
                    }

                    if (x < 0)
                    {
                        textBox10.Text = "Периметр < 0!".ToString();
                        return;
                    }

                    else
                    {
                        textBox10.Text = (Math.Pow((x / 4), 2)).ToString();
                    }
                }
            }

            void Rhomb_Box()
            {
                string p = textBox4.Text;
                double x;

                if (p.Length == 0)
                {
                    textBox11.Text = "Введите периметр!".ToString();
                    return;
                }

                else
                {
                    try
                    {
                        x = Convert.ToDouble(p);
                    }
                    catch (Exception)
                    {
                        textBox11.Text = "Введите число!".ToString();
                        return;
                    }

                    if (x < 0)
                    {
                        textBox11.Text = "Периметр < 0!".ToString();
                        return;
                    }

                    else
                    {
                        double side = x / 4;
                        textBox11.Text = (2 * ((Math.Sqrt(3) / 4) * Math.Pow(side, 2))).ToString();
                    }
                }
            }

            void Pentagon_Box()
            {
                string p = textBox5.Text;
                double x;

                if (p.Length == 0)
                {
                    textBox12.Text = "Введите периметр!".ToString();
                    return;
                }

                else
                {
                    try
                    {
                        x = Convert.ToDouble(p);
                    }
                    catch (Exception)
                    {
                        textBox12.Text = "Введите число!".ToString();
                        return;
                    }

                    if (x < 0)
                    {
                        textBox12.Text = "Периметр < 0!".ToString();
                        return;
                    }

                    else
                    {
                        double side = x / 5;
                        textBox12.Text = ((5 * Math.Pow(side, 2)) / (4 * Math.Tan(Math.PI / 5))).ToString();
                    }
                }
            }

            void Rectangle_Box()
            {
                string p = textBox6.Text;
                double x;

                if (p.Length == 0)
                {
                    textBox13.Text = "Введите периметр!".ToString();
                    return;
                }

                else
                {
                    try
                    {
                        x = Convert.ToDouble(p);
                    }
                    catch (Exception)
                    {
                        textBox13.Text = "Введите число!".ToString();
                        return;
                    }

                    if (x < 0)
                    {
                        textBox13.Text = "Периметр < 0!".ToString();
                        return;
                    }

                    else
                    {
                        double shortSide = x / 6;
                        double longSide = 2 * shortSide;
                        textBox13.Text = (shortSide * longSide).ToString();
                    }
                }
            }

            void Hexagon_Box()
            {
                string p = textBox7.Text;
                double x;

                if (p.Length == 0)
                {
                    textBox14.Text = "Введите периметр!".ToString();
                    return;
                }

                else
                {
                    try
                    {
                        x = Convert.ToDouble(p);
                    }
                    catch (Exception)
                    {
                        textBox14.Text = "Введите число!".ToString();
                        return;
                    }

                    if (x < 0)
                    {
                        textBox14.Text = "Периметр < 0!".ToString();
                        return;
                    }

                    else
                    {
                        double side = x / 6;
                        textBox14.Text = ((3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2)).ToString();
                    }
                }
            }

            Circle_Box();
            Triangle_Box();
            Square_Box();
            Rhomb_Box();
            Pentagon_Box();
            Rectangle_Box();
            Hexagon_Box();
        }
    }
}
