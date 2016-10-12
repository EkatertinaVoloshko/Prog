using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ikl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число :");
            int a;
            a = int.Parse(Console.ReadLine());
            int b;
            int c, d;

                b = a % 10;
                c = (a / 10) % 10;
                d = a / 100;
                Console.WriteLine("Цифры числа");
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);
                Console.ReadLine();

          


        }
    }
}
