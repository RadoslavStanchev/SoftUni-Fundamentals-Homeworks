using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string h = "Hello";
            string w = "World";
            object hw = ("Hello" + " " + "World");
            string sentence = (string)hw;
            Console.WriteLine(sentence);
        }
    }
}
