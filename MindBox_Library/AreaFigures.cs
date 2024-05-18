using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   


namespace MindBox_Library
{
    public static class AreaFigures
    {
        public static double CirclesArea(double radius)// Вычисление S круга "при помощи S = ПR^2"
        {
            if (radius <= 0)
            {
                throw new ArgumentException("R must be positive!!!.");
            }
                
            return Math.PI * radius * radius;
        }

        public static double TrianglesArea(double side1, double side2, double side3)// Вычисления S треугольника по трем сторонам с помощью формулы Герона
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("The lengths of the sides of the triangle must be positive numbers.");
            }

            double perimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
        }

        public static bool CheckIsRightTriangle(double side1, double side2, double side3)// #1 Метод для проверки треугольника на прямоугольность
        {
            // Находим максимальную сторону (гипотенузу) и длины остальных двух сторон (катетов)
            double hypotenuse = Math.Max(side1, Math.Max(side2, side3));
            double cathetus1, cathetus2;

            if (hypotenuse == side1)
            {
                cathetus1 = side2;
                cathetus2 = side3;
            }
            else if (hypotenuse == side2)
            {
                cathetus1 = side1;
                cathetus2 = side3;
            }
            else
            {
                cathetus1 = side1;
                cathetus2 = side2;
            }

            // Проверяем условие прямоугольности с точностью до эпсилон
            double epsilon = 0.0001;
            return Math.Abs(hypotenuse * hypotenuse - cathetus1 * cathetus1 - cathetus2 * cathetus2) < epsilon;
        }

        public static bool CheckIsRightTriangle2(double sideA, double sideB, double sideC)// #2 Метод для проверки треугольника на прямоугольность
        {
            // Сортировка сторон треугольника по возрастанию
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            // Проверка условия прямоугольности
            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }
    }
}
