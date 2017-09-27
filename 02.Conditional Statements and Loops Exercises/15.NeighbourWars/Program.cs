using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int counter = 0;

            for (int i = 1; ; i++)
            {
                counter++;

                if (i % 2 != 0)
                {
                    goshoHealth -= peshoDamage;

                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                }
                else
                {
                    peshoHealth -= goshoDamage;

                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }
                }

                if (peshoHealth <= 0 || goshoHealth <= 0) break;

                if (i % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }

            string winner = (peshoHealth > goshoHealth) ? "Pesho" : "Gosho";

            Console.WriteLine($"{winner} won in {counter}th round.");
        }
    }
}
