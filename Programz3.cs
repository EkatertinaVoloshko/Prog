using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0.1;
            double F = 0;
           
            while (x <= 1.0)
            {
                F = x + 5;
                Console.Write("F= " + F);
                Console.WriteLine(" x= " + x);
                x = x + 0.1;
            }
            Console.ReadLine();
        }
    }
}