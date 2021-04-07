using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);

            Console.WriteLine("Write the number for x1");
            double x1 = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Write the number for y1");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write the number for x2");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write the number for y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("{0:f2}", r);



            
        }
    }
}
