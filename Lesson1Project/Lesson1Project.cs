using System;

namespace Lesson1Project
{
    class Lesson1Project
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            Console.WriteLine($"Привет, {Console.ReadLine()}, сегодня {DateTime.Today.ToLongDateString()}");
            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
