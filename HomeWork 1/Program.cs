
//ДЗ Екатерины Осиповой 
//Консоль выводит вместо кириллицы знаки вопроса, поэтому все задания на англ языке

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
                
            // Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            

            Console.WriteLine("Write your name");
            string name = Console.ReadLine();

            Console.WriteLine("Write your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Write your age");
            string age = Console.ReadLine();

            Console.WriteLine("Write your height in cm");
            string height = Console.ReadLine();

            Console.WriteLine("Write your weight in kg");
            string weight = Console.ReadLine();

            //а) используя склеивание;

            Console.WriteLine("You are " + name +" "+ surname+" " + age + " "+"years old, " + "height is " + height +" "+ "and weight is " + weight );


            //б) используя форматированный вывод;

            Console.WriteLine(String.Format("You are {0} {1} {2} years old, height is {3} and weight is {4}", name, surname, age, height, weight ));


            //в) используя вывод со знаком $.

            Console.WriteLine($"You are {name} {surname} {age} years old, height is {height} and weight is {weight}");
        }
    }
}
