using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FarmerLibrary
{
    /// <summary>
    /// Класс Farmer в котором находятся методы для нахождения площади геометрических фигур зная лишь их периметр
    /// </summary>

    public static class Farmer
    {
        /// <summary>
        // Метод вычисления площади равностороннего треугольника
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>равностороннего треугольника</returns>
        public static double EquilateralTriangleArea(double perimeter) 
        { 
            return perimeter * perimeter / (12 * Math.Sqrt(3)); 
        }

        /// <summary>
        /// Метод вычисления площади правильного ромба, состоящего из двух равносторонних треугольников
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь правильного ромба, состоящего из двух равносторонних треугольников</returns>
        public static double RhombusArea(double perimeter)
        {
            return perimeter * perimeter * Math.Sqrt(3) / 32;
        }

        /// <summary>
        /// Метод вычисления площади прямоугольника, у которого одна сторона вдвое больше другой
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь прямоугольника, у которого одна сторона вдвое больше другой</returns>
        public static double RectangleArea(double perimeter)
        {
            return perimeter * perimeter / 18;
        }

        /// <summary>
        /// Метод вычисления площади квадрата
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь квадрата</returns>
        public static double SquareArea(double perimeter)
        {
            return perimeter * perimeter / 16;
        }    

        /// <summary>
        /// Метод вычисления площади правильного пятиугольника
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь правильного пятиугольника</returns>
        public static double PentagonArea(double perimeter)
        {
            return perimeter * perimeter / (20 * Math.Tan(Math.PI / 5));
        }

        /// <summary>
        /// Метод вычисления площади правильного шестиугольника
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь правильного шестиугольника</returns>
        public static double HexagonArea(double perimeter)
        {
            return perimeter * perimeter / (8 * Math.Sqrt(3));
        }

        /// <summary>
        /// Метод вычисления площади правильного n-угольника
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь правильного n-угольника</returns>
        public static double N_gonArea(double perimeter, int n)
        {
            return perimeter * perimeter / (n * 4 * Math.Tan(Math.PI / n));
        }

        /// <summary>
        /// Метод вычисления площади круга
        /// </summary>
        /// <param name="perimeter"></param>
        /// <returns>площадь круга</returns>
        public static double CircleArea(double perimeter)
        {
            return perimeter * perimeter / (4 * Math.PI);;
        }
    }
}
