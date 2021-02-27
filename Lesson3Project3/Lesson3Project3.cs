using System;

namespace Lesson3Project3
{
    class Lesson3Project3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку для отображения в обратном порядке: ");
            string str = Console.ReadLine();

            Console.Write("Строка в обратном порядке: ");
            for (int i = str.Length - 1; i >= 0; Console.Write(str[i--]));
            Console.WriteLine();

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
