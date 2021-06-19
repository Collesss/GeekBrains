using System;
using System.IO;

namespace Lesson5Project1
{
    class Lesson5Project1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст для сохранения в файл: ");
            string text = Console.ReadLine();

            Console.Write("Введите имя файла: ");
            string fileName = $"{Console.ReadLine()}.txt";

            File.WriteAllText(fileName, text);

            Console.WriteLine($"Данные записаны в файл: {fileName}");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
