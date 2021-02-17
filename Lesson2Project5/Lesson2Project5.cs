﻿using System;

namespace Lesson2Project5
{
    class Lesson2Project5
    {
        enum Month
        {
            Январь = 1,
            Февраль = 2,
            Март = 3,
            Апрель = 4,
            Май = 5,
            Июнь = 6,
            Июль = 7,
            Август = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь = 11,
            Декабрь = 12
        }

        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            int numMounth = Convert.ToInt32(Console.ReadLine());

            if (!(numMounth >= 1 && numMounth <= 12))
            {
                Console.WriteLine("Введён неверный номер месяца");

                Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
                Console.ReadKey();
            }

            Console.Write("Введите минимальную температуру за сутки: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальную температуру за сутки: ");
            int max = Convert.ToInt32(Console.ReadLine());

            double avgTemp = (min + max) / 2d;

            Console.WriteLine($"Месяц: {(Month)numMounth, -8}, средняя температура {avgTemp:F2}");

            if (avgTemp > 0)
                switch (numMounth)
                {
                    case 1:
                    case 11:
                    case 12:
                        Console.WriteLine("Дождливая зима.");
                    break;
                }

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
