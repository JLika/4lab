using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            string k;

            Console.WriteLine("Введите a:");
            Console.WriteLine();
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите b:");
            Console.WriteLine();
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак:");
            Console.WriteLine();
            k = Convert.ToString(Console.ReadLine());


        }


        public void del(int a, int b)
        {
            Console.WriteLine($" Результат: {a} / {b} = " + (a / b));
        }
    }
}
