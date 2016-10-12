using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Волошко Екатерина, 10МИ3
Вариант №8
*/

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; //Координаты точки
            bool g;     //Значение функции   
            string str; //Строка ввода и вывода данных


            Console.Clear();
            Console.Write("Введите x: ");
            str = Console.ReadLine();
            x = double.Parse(str);
            Console.Write("Введите y: ");
            str = Console.ReadLine();
            y = double.Parse(str);

            if (x >= 1.0 && y >= 1.1)
                if (x <= 2.5)
                    if (y <= 2.1)
                    {
                        g = true; // Следовательно в фигуре
                    }
                    else
                    {
                        g = false; // Следовательно не в фигуре
                    }
                else
                {
                    g = false; // Следовательно не в фигуре
                }
            else
            {
                g = false; // Следавательно не в фигуре
            }

            str = string.Format("G({0:f3},{1:f3}) = {2}", x, y, g);

            Console.WriteLine(str);

            Console.ReadLine();


        }
    } //Конец определения метода
}// Конец определения класса
    

