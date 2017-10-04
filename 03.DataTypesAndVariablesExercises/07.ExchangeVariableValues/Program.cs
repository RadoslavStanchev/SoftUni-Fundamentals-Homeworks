using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", b);
            Console.WriteLine("b = {0}", a);
        }
    }
}
