﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 0, value2 = 0;
            string chain;
            Console.WriteLine("Give me the first value:");
            chain = Console.ReadLine();
            value1 = Convert.ToInt32(chain);
            Console.WriteLine("Give me the second value:");
            chain = Console.ReadLine();
            value2 = Convert.ToInt32(chain);
            if (value1 <= value2)
            {
                if (value1 == value2)
                    Console.WriteLine("The value of 1 is equal to value of 2");
                else
                    Console.WriteLine("The value of 2 is greater than value of 1");
            }
            else
                Console.WriteLine("The value of 1 is grater than the value of 2");
            Console.ReadKey();
        }
    }
}
