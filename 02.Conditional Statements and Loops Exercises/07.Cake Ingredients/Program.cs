using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0;i <= 20; i++)
            {
                string ingredients = Console.ReadLine();
                if (ingredients != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredients}.");
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }
            }
        }
    }
}
