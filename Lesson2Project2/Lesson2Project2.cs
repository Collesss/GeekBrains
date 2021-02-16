using System;

namespace Lesson2Project2
{
    class Lesson2Project2
    {
        enum Month
        {
            Январь      =  1,
            Февраль     =  2,
            Март        =  3,
            Апрель      =  4,
            Май         =  5,
            Июнь        =  6,
            Июль        =  7,
            Август      =  8,
            Сентябрь    =  9,
            Октябрь     = 10,
            Ноябрь      = 11,
            Декабрь     = 12
        }

        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            int numMounth = Convert.ToInt32(Console.ReadLine());

            if (numMounth >= 1 && numMounth <= 12)
                Console.WriteLine($"Месяц с порядковым номером: {numMounth,2:D}, называется \"{(Month)numMounth}\"");
            else
                Console.WriteLine("Введён неверный номер месяца");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
