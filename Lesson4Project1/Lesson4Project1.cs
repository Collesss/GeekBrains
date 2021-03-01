using System;

namespace Lesson4Project1
{
    class Lesson4Project1
    {
        static void Main(string[] args)
        {
            string[][] flpArr = {
                new string[]{ "Test11", "Test12", "Test13" },
                new string[]{ "Test21", "Test22", "Test23" },
                new string[]{ "Test31", "Test32", "Test33" },
                new string[]{ "Test41", "Test42", "Test43" }
            };

            foreach(string[] flp in flpArr)
                Console.WriteLine(GetFullName(flp[0], flp[1], flp[2]));

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }

        static string GetFullName(string firstName, string lastName, string patronymic) =>
            $"{firstName} {lastName} {patronymic}";
    }
}
