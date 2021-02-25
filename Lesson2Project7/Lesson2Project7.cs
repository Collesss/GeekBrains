using System;

namespace Lesson2Project7
{
    class Lesson2Project7
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            long year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"год {year} {((year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? string.Empty : "не ")}високосный");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
