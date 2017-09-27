using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double totalprice = 0;
            double pricePerPerson = 0;
            if (groupSize <= 50)
            {
                if (package == "Normal")
                {
                    //0.95 because 100% - 5% = 95* and since we are multiplying => 0.95
                    totalprice = (2500 + 500) * 0.95;
                    pricePerPerson = totalprice / groupSize;
                }
                else if (package == "Gold")
                {
                    totalprice = (2500 + 750) * 0.90;
                    pricePerPerson = totalprice / groupSize;

                }
                else
                {
                    totalprice = (2500 + 1000) * 0.85;
                    pricePerPerson = totalprice / groupSize;
                }
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (groupSize > 50 && groupSize <= 100)

            {
                if (package == "Normal")
                {
                    totalprice = (5000 + 500) * 0.95;
                    pricePerPerson = totalprice / groupSize;
                }
                else if (package == "Gold")
                {
                    totalprice = (5000 + 750) * 0.90;
                    pricePerPerson = totalprice / groupSize;
                }
                else
                {
                    totalprice = (5000 + 1000) * 0.85;
                    pricePerPerson = totalprice / groupSize;
                }
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                if (package == "Normal")
                {
                    totalprice = (7500 + 500) * 0.95;
                    pricePerPerson = totalprice / groupSize;
                }
                else if (package == "Gold")
                {
                    totalprice = (7500 + 750) * 0.90;
                    pricePerPerson = totalprice / groupSize;
                }
                else
                {
                    totalprice = (7500 + 1000) * 0.85;
                    pricePerPerson = totalprice / groupSize;

                }
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            

        }
    }
}
