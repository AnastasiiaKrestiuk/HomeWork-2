using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, целое число:");

            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) Console.WriteLine("Вы ввели четное число.");
            else Console.WriteLine("Вы ввели нечетное число.");
        }
    }
}
