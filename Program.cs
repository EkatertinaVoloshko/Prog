using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число для сложения:");
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);

            Console.WriteLine("Введите второе число для сложения:");
            string s2 = Console.ReadLine();
            int b = Convert.ToInt32(s2);

            int c = a + b;
            Console.WriteLine("Сумма данных чисел:");
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
