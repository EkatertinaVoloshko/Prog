using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Волошко._16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Волошко Екатерина
              группа 10МИ3 (М4)
              Вариант 16
              09.11.2016
             */
            int cifra, // Первое число ( код цифры )
                bukva, // Второе число ( код буквы )
                delta, // Величина сдвига в алфавите
                newbukva; // Код новой буквы
            char rep; // Признак повторного выполнения
            string str; // Строка приема и вывода данных

            do
            {
                Console.Clear();
                Console.Write("Введите код цифры: ");
                str = Console.ReadLine();
                cifra = int.Parse(str);
                Console.Write("Введите код буквы : ");
                str = Console.ReadLine();
                bukva = int.Parse(str);

                newbukva = bukva;
                if (cifra >= '0' && cifra <= '9')
                {
                    delta = cifra - '0';
                    if (bukva >= 'A' && bukva <= 'Z')
                    {
                        newbukva = bukva + delta;
                        if (newbukva > 'Z') newbukva = bukva;
                    }
                }
                if (newbukva == bukva)
                    str = "Преобразование не выполняется ";
                else 
                    str = string.Format("{0} -> {1}", (char)bukva,(char)newbukva);
                Console.WriteLine(str);
                Console.WriteLine("Для повтора вычислений нажмите клавишу Y: ");
                rep = char.Parse(Console.ReadLine());
                Console.WriteLine();
            }while(rep == 'Y' || rep == 'y');
        
    
                   

        }
    }
}
