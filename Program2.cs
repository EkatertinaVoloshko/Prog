using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Введите x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("\nВведите y: ");
            y = double.Parse(Console.ReadLine());
            if (x * x + y * y <= 4 && x >= 0 && x <= Math.Sqrt(2) && y >= -2 && y <= Math.Sqrt(2)) Console.Write("\nTrue");
            else Console.Write("\nFalse");
            Console.ReadKey();
        }
    }
}
