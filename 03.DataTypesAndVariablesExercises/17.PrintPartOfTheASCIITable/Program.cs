using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                Console.Write("{0} ", (char)i);
            }
        }
    }
}
