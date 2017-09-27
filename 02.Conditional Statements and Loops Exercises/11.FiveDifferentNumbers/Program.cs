using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            if (endNum - startNum < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = startNum; i <= endNum - 4; i++)
            {
                for (int a = i + 1; a <= endNum - 3; a++)
                {
                    for (int b = a + 1; b <= endNum - 2; b++)
                    {
                        for (int c = b + 1; c <= endNum - 1; c++)
                        {
                            for (int d = c + 1; d <= endNum; d++)
                            {
                                Console.WriteLine($"{i} {a} {b} {c} {d}");
                            }

                        }
                    }
                }
            }
        }
    }
}
