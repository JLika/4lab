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

            switch (k)
            {
                case "+":
                    plus(a,b);
                    break;
                case "-":
                    minus(a, b);
                    break;
                case "*":
                    umnoj(a, b);
                    break;
                case "/":
                    del(a, b);
                    break;
            }

        }


        public static void plus(int a, int b)
        {
            Console.WriteLine($" Результат: {a} + {b} = " + (a + b));

        }


        public static void del(int a, int b)
        {
            Console.WriteLine($" Результат: {a} / {b} = " + (a / b));

        }


    }
}
