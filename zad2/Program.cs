﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;


            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine($"SUM: {sum}");
            Console.ReadLine();
        }
    }
}
