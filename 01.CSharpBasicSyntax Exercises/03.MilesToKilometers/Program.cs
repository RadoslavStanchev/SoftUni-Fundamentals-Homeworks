using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            double miles = kilometers * 1.60934;
            Console.WriteLine($"{miles:F2}");
        }
    }
}