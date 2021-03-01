using System;
using System.IO;

namespace Lesson5Project2
{
    class Lesson5Project2
    {
        static void Main(string[] args)
        {
            string fileName = "startup.txt";

            File.AppendAllText(fileName, $"{DateTime.Now}\n");

            Console.WriteLine($"Текущие дата и время дописаны в файл \"{fileName}\"");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
