﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int maxNum = Math.Max(num1, num2);
            int minNum = Math.Min(num1, num2);
            for (int i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
