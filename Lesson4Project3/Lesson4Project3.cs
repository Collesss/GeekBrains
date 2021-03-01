using System;

namespace Lesson4Project3
{
    class Lesson4Project3
    {
        enum Season
        {
            None,
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {
            int numMounth;

            string inputStr = null;

            do
            {
                if(inputStr != null)
                    Console.WriteLine("Неверный ввод попробуйте снова.");
                
                Console.Write("Введите номер месяца от 1 до 12 для получения времени года: ");
            }
            while (!Int32.TryParse(inputStr = Console.ReadLine(), out numMounth) || !(numMounth > 0 && numMounth <= 12));

            Console.WriteLine($"Время года по номеру месяца: {GetNameSeason(GetSeason(numMounth))}");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }

        static Season GetSeason(int numMounth)
        {
            Season season = Season.None;

            if (numMounth > 0 && numMounth <= 2 || numMounth == 12)
                season = Season.Winter;
            else if (numMounth > 2 && numMounth <= 5)
                season = Season.Spring;
            else if (numMounth > 5 && numMounth <= 8)
                season = Season.Summer;
            else if (numMounth > 8 && numMounth <= 11)
                season = Season.Autumn;

            return season;
        }

        static string GetNameSeason(Season season)
        {
            string[][] nameSeason = {
                new string[]{ "Winter", "Зима" },
                new string[]{ "Spring", "Весна" },
                new string[]{ "Summer", "Лето" },
                new string[]{ "Autumn", "Осень" }
            };

            string retName = "";

            foreach (string[] names in nameSeason)
                if (names[0] == season.ToString())
                {
                    retName = names[1];
                    break;
                }

            return retName;
        }
    }
}
