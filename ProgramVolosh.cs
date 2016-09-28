using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int a;
            Console.WriteLine ("Введите оценку ");
            a = int.Parse(Console.ReadLine());
            if (a < 3)
            {
                Console.WriteLine("Не зачет");
            }
            else

            {
                Console.WriteLine("Зачет");
            }
            Console.ReadLine();
        }
    }
}
        
