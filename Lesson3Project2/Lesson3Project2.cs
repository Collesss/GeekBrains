using System;

namespace Lesson3Project2
{
    class Lesson3Project2
    {
        static void Main(string[] args)
        {
            string[][] mailCatalog = new string[][] {
                new string[]{ "test0", "test0@mail.ru"},
                new string[]{ "test1", "test1@mail.ru"},
                new string[]{ "test2", "test2@mail.ru"},
                new string[]{ "test3", "test3@mail.ru"},
                new string[]{ "test4", "test4@mail.ru"},
                new string[]{ "test5", "test5@mail.ru"},
                new string[]{ "test6", "test6@mail.ru"},
                new string[]{ "test7", "test7@mail.ru"},
                new string[]{ "test8", "test8@mail.ru"},
                new string[]{ "test9", "test9@mail.ru"}
            };

            Console.WriteLine("Справочник");

            for (int i = 0; i < mailCatalog.Length; Console.WriteLine($"name: {mailCatalog[i][0]}; email: {mailCatalog[i++][0]};"));

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
