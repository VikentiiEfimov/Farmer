using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Метод вычисления площади квадрата
        /// </summary>
        /// <param name="perimeter">Периметр квадрата (положительное число типа double )</param>
        /// <returns>Площадь квадрата</returns>
        public static double SquareArea(double perimeter)
        {
            double a = perimeter / 4; // Сторона квадрата
            double s = a * a;
            return s;

        }
        /// <summary>
        /// Метод вычисления площади равностороннего треугольника
        /// </summary>
        /// <param name="perimeter">Периметр равностороннего треугольника (положительное число типа double )</param>
        /// <returns>Площадь равностороннего треугольника</returns>
        public static double EquilateralTriangleArea(double perimeter)
        {  
            double side = perimeter / 3; // Сторона равностороннего треугольника
            return (Math.Sqrt(3) / 4) * side * side;
        }

        /// <summary>
        /// Метод вычисления площади правильного ромба
        /// </summary>
        /// <param name="perimeter">Периметр равностороннего треугольника (положительное число типа double)</param>
        /// <returns>Площадь правильного ромба</returns>
        public static double RhombusArea(double perimeter)
        {
            double side = perimeter / 4; // сторона правильного ромба
            return 2 * ((Math.Sqrt(3) / 4) * side * side);
        }

        /// <summary>
        /// Метод вычисления площади правильного пятиугольника
        /// </summary>
        /// <param name="perimeter">Периметр правильного пятиугольника (положительное число типа double)</param>
        /// <returns></returns> 
        public static double PentagonArea(double perimeter)
        { 
            double side = perimeter / 5; // Сторона правильного пятиугольника
            return (5 * side * side) / (4 * Math.Tan(Math.PI / 5)); // Тангенс пи/5
        }

        /// <summary>
        /// Метод вычисления площади прямоугольника, у которого одна сторона вдвое больше другой
        /// </summary>
        /// <param name="perimeter">Периметр прямоугольника, у которого одна сторона вдвое больше другой (положительное число типа double)</param>
        /// <returns>Площадь прямоугольника, у которого одна сторона вдвое больше другой</returns>        
        public static double RectangleArea(double perimeter)
        {
            double shortSide = perimeter / 6; //Малая сторона
            double longSide = 2 * shortSide; //Большая сторона
            return shortSide * longSide;
        }

        /// <summary>
        /// Метод вычисления площади круга
        /// </summary>
        /// <param name="perimeter">Периметр круга (положительное число типа double)</param>
        /// <returns>Площадь круга</returns>
        public static double CircleArea(double perimeter)
        {
            double radius = perimeter / (2 * Math.PI); // Радиус
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Метод вычисления площади правильного шестиугольника
        /// </summary>
        /// <param name="perimeter">Периметр правильного шестиугольника (положительное число типа double)</param>
        /// <returns>Площадь правильного шестиугольника </returns>
        public static double HexagonArea(double perimeter)
        {
            double side = perimeter / 6; // сторона
            return (3 * Math.Sqrt(3) / 2) * side * side;
        }
    }
}
