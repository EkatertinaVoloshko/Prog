using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число:");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.Write("Число четное. Результат программы {0}", a / 2);
            }
            else
            {
                Console.Write("Число нечетное. Результат программы {0}", (a + 1) / 2);
            }
            Console.ReadLine();
            }
        }  
    }
