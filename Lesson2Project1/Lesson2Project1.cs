using System;

namespace Lesson2Project1
{
    class Lesson2Project1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру за сутки: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальную температуру за сутки: ");
            int max = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Среднесуточная температура равна: {(min+max)/2d:F2}");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
