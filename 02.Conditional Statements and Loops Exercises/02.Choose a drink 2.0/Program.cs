using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double water = 0.70;
            double coffee = 1.00;
            double beer = 1.70;
            double tea = 1.20;
            double sum = 0;
            if (profession == "Athlete")
            {
                sum = water * quantity;
                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                sum = coffee * quantity;
                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                sum = beer * quantity;
                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
            else
            {
                sum = tea * quantity;
                Console.WriteLine($"The {profession} has to pay {sum:F2}.");
            }
        }
    }
}
