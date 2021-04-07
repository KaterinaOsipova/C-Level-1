using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле
            //I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("What's your weight in kg?");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What's your height in m?");
            double h = Convert.ToDouble(Console.ReadLine());

            double BMI = m / (h * h);

            Console.WriteLine($"Your BMI is {BMI.ToString("#.00")}");


        }
    }
}
