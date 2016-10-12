using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo;
            int cifra;
            int i;
            string str;
            Console.WriteLine("Введите ваше число");
            str = Console.ReadLine();
            chislo = int.Parse(str);
            i = 0;
            while (chislo >= 10)
            {
                cifra = chislo % 10;
                i = i + 1;
                str = "Ваша " + i + "-ая цифра";
                Console.WriteLine(str);
                Console.WriteLine(cifra);
                chislo = chislo / 10;
            }
            cifra = chislo % 10;
            i = i + 1;
            str = "Ваша " + i + "-ая цифра";
            Console.WriteLine(str);
            Console.WriteLine(cifra);
            Console.ReadKey();
        }
    }
}
    