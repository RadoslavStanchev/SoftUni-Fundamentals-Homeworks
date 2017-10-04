using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            bool boolean = Convert.ToBoolean(n);
            if (boolean)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
