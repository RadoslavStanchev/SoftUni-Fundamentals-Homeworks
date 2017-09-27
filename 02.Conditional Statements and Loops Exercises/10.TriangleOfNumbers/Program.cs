using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangleSize = int.Parse(Console.ReadLine());
            for (int i = 1; i <= triangleSize; i++)
            {
                for (int n = 1; n <= i; n++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
