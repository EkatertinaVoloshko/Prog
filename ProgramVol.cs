using System;

namespace task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a;
            Console.Write("Введите число");
            a = int.Parse(Console.ReadLine());
            if (a % 4 == 0)
            {
                Console.WriteLine("{0}", a / 4);
            }
            else
            {
                Console.WriteLine("{0}", a + 4);
            }
            Console.ReadLine();
        }
    }
}