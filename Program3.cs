using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите x");
            string str = Console.ReadLine();
            double x = double.Parse(str);

            Console.WriteLine("введите y");
            str = Console.ReadLine();
            double y = double.Parse(str);

            double g = 0;
            if (x < y && x > 0)
            {
                g = x + Math.Sin(y);

            }

            if (x < y && x < 0)
            {

                g = y - Math.Cos(x);
            }

            if (x > y)
            {
                g = 0.5 * x * y;
            }

            Console.WriteLine("Вы ввели x= " + x + " \nи y = " + y + "\n Результат работы программы = " + g);
            Console.ReadLine();

        }
    }
}
