using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            bool TypeOfMagic = false;
            string lastMagic = "";
            int combinationsCount = 0;
            for (int i = number1; i <= number2; i++)
            {
                for (int j = number1; j <= number2; j++)
                {
                    combinationsCount++;
                    if (i + j == magicNumber)
                    {
                        lastMagic = $"Number found! {i} + {j} = {magicNumber}";
                        TypeOfMagic = true;
                    }
                }
            }

            if (TypeOfMagic)
            {
                Console.WriteLine(lastMagic);
            }
            else
            {
                Console.WriteLine($"{combinationsCount} combinations - neither equals {magicNumber}");
            }
        }
    }
}
