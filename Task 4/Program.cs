using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;

            int a = 5;
            int b = 10;

            Console.WriteLine($"a = {a}, b={b}");
            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"a = {a}, b={b}");


            //б) *без использования третьей переменной.

            int e = 10;
            int d = 20;

            Console.WriteLine($"e = {e}, d={d}");

            d = e + d;
            e = d - e;
            d = d - e;

            Console.WriteLine($"e = {e}, d={d}");
        }
    }
}
