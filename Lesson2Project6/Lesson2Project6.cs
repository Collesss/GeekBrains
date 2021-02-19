using System;

namespace Lesson2Project6
{
    class Lesson2Project6
    {
        [Flags]
        enum Week : byte
        {
            None        = 0b0000_0000,
            Понедельник = 0b0000_0001,
            Вторник     = 0b0000_0010,
            Среда       = 0b0000_0100,
            Четверг     = 0b0000_1000,
            Пятница     = 0b0001_0000,
            Суббота     = 0b0010_0000,
            Воскресенье = 0b0100_0000,
            Вся_неделя  = 0b0111_1111,
            All         = 0b1111_1111
        }


        static void Main(string[] args)
        {
            Week office1 = Week.Понедельник | Week.Вторник | Week.Четверг | Week.Пятница | Week.Суббота;
            Week office2 = Week.Понедельник | Week.Вторник | Week.Среда | Week.Четверг | Week.Пятница;
            Week office3 = Week.Вторник | Week.Среда | Week.Четверг | Week.Суббота | Week.Воскресенье;
            Week office4 = Week.Понедельник | Week.Вторник | Week.Среда | Week.Четверг | Week.Пятница | Week.Суббота | Week.Воскресенье;

            Console.WriteLine($"Первый оффис работает в {office1}\nВторой оффис работает в {office2}\nТретий оффис работает в {office3}\nЧетвёртый оффис работает в {office4}");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
