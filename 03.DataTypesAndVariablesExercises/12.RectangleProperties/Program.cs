using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {

            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double rectanglePerimeter = (sideA + sideB) * 2;
            Console.WriteLine(rectanglePerimeter);

            double rectangleArea = sideA * sideB;
            Console.WriteLine(rectangleArea);

            double rectangleDiagonal = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            Console.WriteLine(rectangleDiagonal);
        }
    }
}
