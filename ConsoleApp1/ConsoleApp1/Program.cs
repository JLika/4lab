using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            



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


        public void minus(int a, int b)
        {
            Console.WriteLine($" Результат: {a} - {b} = " + (a - b));
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
