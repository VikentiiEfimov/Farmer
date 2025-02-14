using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FarmerLibrary
{
    /// <summary>
    /// Класс Farmer в котором находятся методы для нахождения площади зная лишь периметр
    /// </summary>

    public static class Farmer
    {
        /// <summary>
        /// Метод вычисления площади равностороннего треугольника
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь равностороннего треугольника</returns>
        public static double EquilateralTriangleArea(double perimeter)
        {
            double a = perimeter / 3; // сторона равностороннего треугольника
            double s = a * a * Math.Sqrt(3) / 4;
            return s;
        }

        /// <summary>
        /// Метод вычисления площади квадрата
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь квадрата</returns>
        public static double SquareArea(double perimeter)
        {
            double a = perimeter / 4; // сторона квадрата
            double s = a * a;
            return s;
        }

        /// <summary>
        /// Метод вычисления площади правильного ромба, состоящего из двух равносторонних треугольников
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь правильного ромба, состоящего из двух равносторонних треугольников</returns>
        public static double RhombusArea(double perimeter)
        {
            double a = perimeter / 4; //сторона правильного ромба, состоящего из двух равносторонних треугольников
            double s = a * a * Math.Sqrt(3) / 2;
            return s;
        }
        
        /// <summary>
        /// Метод вычисления площади прямоугольника, у которого одна сторона вдвое больше другой
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь прямоугольника, у которого одна сторона вдвое больше другой</returns>
        public static double RectangleArea(double perimeter)
        {
            double a = perimeter / 6; //сторона прямоугольника, у которого одна сторона вдвое больше другой
            double s = a * a * 2;
            return s; 
        }

        /// <summary>
        /// Метод вычисления площади правильного пятиугольника
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь правильного пятиугольника</returns>
        public static double PentagonArea(double perimeter)
        {
            double a = perimeter / 5; //сторона правильного пятиугольника
            double s = a * a * 5 / (4 * Math.Tan(Math.PI / 5));
            return s;
        }

        /// <summary>
        /// Метод вычисления площади правильного шестиугольника
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь правильного шестиугольника</returns>
        public static double HexagonArea(double perimeter)
        {
            double a = perimeter / 6; //сторона правильного шестиугольника
            double s = a * a * 1.5 * Math.Sqrt(3);
            return s;
        }

        /// <summary>
        /// Метод вычисления площади правильного n-угольника
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь правильного n-угольника</returns>
        public static double N_gonArea(double perimeter, int n)
        {
            double a = perimeter / n; //сторона правильного n-угольника
            double s = a * a * n / (4 * Math.Tan(Math.PI / n));
            return s;
        }

        /// <summary>
        /// Метод вычисления площади круга
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь круга</returns>
        public static double CircleArea(double perimeter)
        {
            double r = perimeter / (2 * Math.PI);
            double s = r * r * Math.PI;
            return s;
        }
    }
}
