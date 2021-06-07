using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста максимальное значение температуры за сутки:"); //запрашиваем значение. Разделитель - запятая. Если вводят точку - не работает.

            double max = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите, пожалуйста минимальное значение температуры за сутки:");

            double min = double.Parse(Console.ReadLine());

            Console.WriteLine((min + max) / 2);
        }
    }
}
