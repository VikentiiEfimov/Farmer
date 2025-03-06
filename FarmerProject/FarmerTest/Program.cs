using FarmerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FarmerTest
{
    public class Program
    {
        public static void Test1() // Тест площади круга CircleArea
        {
            double p = 894.132;
            double s = Math.Round(Farmer.CircleArea(106), 3);
            Console.WriteLine("Площадь круга: " + (p == s));
        }

        static void Test2() // Тест площади равностороннего треугольника EquilateralTriangleArea
        {
            double p = 54.641;
            double s = Math.Round(Farmer.EquilateralTriangleArea(33.7), 3);
            Console.WriteLine("Площадь равностороннего треугольника: " + (p == s));
        }

        static void Test3() // Тест площади квадрата SquareArea
        {
            double p = 1;
            double s = Farmer.SquareArea(4);
            Console.WriteLine("Площадь квадрата: " + (p == s));
        }

        static void Test4() // Тест площади правильного ромба RhombusArea Math.Round((float)n / G, 3)
        {
            double p = 5336.665;
            double s = Math.Round(Farmer.RhombusArea(314), 3);
            Console.WriteLine("Площадь правильного ромба: " + (p == s));
        }
        
        static void Test5() // Тест площади правильного пятиугольника PentagonArea
        {
            double p = 4.996;
            double s = Math.Round(Farmer.PentagonArea(8.52), 3);
            Console.WriteLine("Площадь правильного пятиугольника: " + (p == s));
        }

        static void Test6() // Тест площади прмоугольника, у которого одна сторона вдвое больше другой RectangleArea
        {
            double p = 50;
            double s = Farmer.RectangleArea(30);
            Console.WriteLine("Площадь прямоугольника, у которого одна сторона вдвое больше другой: " + (p == s));
        }

        static void Test7() // Тест площади правильного шестиугольника HexagonArea
        {
            double p = 389.874;
            double s = Math.Round(Farmer.HexagonArea(73.5), 3);
            Console.WriteLine("Площадь правильного шестиугольника: " + (p == s));
        }

        /// <summary>
        /// Тесты и вывод их результатов
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
            Test6();
            Test7();
            Console.ReadKey();
        }
    }
}
