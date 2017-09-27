using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int callories = 0;
            for (int i = 0; i < n; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                if (ingredients == "tomato sauce")
                {
                    callories = callories + 150;
                }
                if (ingredients == "cheese")
                {
                    callories = callories + 500;
                }
                if (ingredients == "salami")
                {
                    callories = callories + 600;
                }
                if (ingredients == "pepper")
                {
                    callories = callories + 50;
                }
            }
            Console.WriteLine("Total calories: " + callories);
        }
    }
}
