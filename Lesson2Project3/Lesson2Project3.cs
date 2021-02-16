using System;

namespace Lesson2Project3
{
    class Lesson2Project3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");

            int num;

            Console.WriteLine($"Число {num = Convert.ToInt32(Console.ReadLine())} {(num % 2 == 0 ? "чётное" : "нечётное")}");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
