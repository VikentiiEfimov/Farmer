using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerLibrary
{


    /// <summary>
    /// Класс Farmer в котором находятся методы для нахождения площади зная лишь периметр
    /// </summary>
    public static class Farmer
    {

        // Метод вычисления площади квадрата
        public static double SquareArea(double perimeter)
        {
            try
            {
                if (perimeter < 0)
                {
                    Console.WriteLine("Периметр не может быть отрицательным");
                    return 0;

                }
                else
                {
                    double S = Math.Pow((perimeter / 4), 2);
                    return S;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        // Метод вычисления площади равностороннего треугольника
        public static double EquilateralTriangleArea(double perimeter)
        {
            try
            {
                if (perimeter < 0)
                {
                    Console.WriteLine("Периметр не может быть отрицательным");
                    return 0;
                }
                else
                {
                    double side = perimeter / 3;
                    return (Math.Sqrt(3) / 4) * Math.Pow(side, 2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        // Метод вычисления площади правильного ромба (предполагается, что он состоит из двух равносторонних треугольников)
        public static double RhombusArea(double perimeter)
        {
            try
            {
                if (perimeter < 0)
                {
                    Console.WriteLine("Периметр не может быть отрицательным");
                    return 0;
                }
                else
                {
                    double side = perimeter / 4;
                    return 2 * ((Math.Sqrt(3) / 4) * Math.Pow(side, 2));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        // Метод вычисления площади правильного пятиугольника
        public static double PentagonArea(double perimeter)
        {
            try
            {
                if (perimeter < 0)
                {
                    Console.WriteLine("Периметр не может быть отрицательным");
                    return 0;
                }
                else
                {
                    double side = perimeter / 5;
                    return (5 * Math.Pow(side, 2)) / (4 * Math.Tan(Math.PI / 5));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        // Метод вычисления площади прямоугольника, у которого одна сторона вдвое больше другой
        public static double RectangleArea(double perimeter)
        {
            try
            {
                if (perimeter < 0)
                {
                    Console.WriteLine("Периметр не может быть отрицательным");
                    return 0;
                }
                else
                {
                    double shortSide = perimeter / 6;
                    double longSide = 2 * shortSide;
                    return shortSide * longSide;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        // Метод вычисления площади круга
        public static double CircleArea(double perimeter)
        {
            try
            {
                if (perimeter < 0)
                {
                    Console.WriteLine("Периметр не может быть отрицательным");
                    return 0;
                }
                else
                {
                    double radius = perimeter / (2 * Math.PI);
                    return Math.PI * Math.Pow(radius, 2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        // Метод вычисления площади правильного шестиугольника
        public static double HexagonArea(double perimeter)
        {
            try
            {
                if (perimeter < 0)
                {
                    Console.WriteLine("Периметр не может быть отрицательным");
                    return 0;
                }
                else
                {
                    double side = perimeter / 6;
                    return (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
