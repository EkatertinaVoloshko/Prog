using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Делимое:");
                         string s = Console.ReadLine();
                        int a = Convert.ToInt32(s);
            


            Console.WriteLine("Введите делитель:");
                         string s2 = Console.ReadLine();
                         int b = Convert.ToInt32(s2);
           


            int c = a % b;
                        Console.WriteLine("Остаток от деления данных чисел:");
                        Console.WriteLine(c);
                        Console.ReadLine();

        }
    }
}
