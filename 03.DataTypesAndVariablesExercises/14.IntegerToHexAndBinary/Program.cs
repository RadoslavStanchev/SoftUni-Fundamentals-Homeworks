using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            String myHexNumber = n.ToString("X");

            Console.WriteLine(myHexNumber);

            int remainder;
            string result = string.Empty;
            while (n > 0)
            {
                remainder = n % 2;
                n /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
