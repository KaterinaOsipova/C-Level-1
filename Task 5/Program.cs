using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.

            Console.WriteLine("Write your name");
            string name = Console.ReadLine();

            Console.WriteLine("Write your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Write your city");
            string city = Console.ReadLine();

            Console.WriteLine($"You are {name} {surname} from {city} ");


            // б) *Сделать задание, только вывод организовать в центре экрана.

            string text = $"You are {name} {surname} from {city} ";
            int width = Console.WindowWidth;
            int padding = width / 2 + text.Length / 2;
            Console.WriteLine("{0," + padding + "}", text);



            
          
        }

        
    }
}
