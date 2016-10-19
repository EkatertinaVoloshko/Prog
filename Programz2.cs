using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum;
            int n;
            n = 1;
            sum = 0;
            for (n = 1; n <= 10; n++) ;
            sum = sum + n * n;
            Console.Write("Сумма чисел " + sum);
            Console.ReadLine();
        }
    }
}
        