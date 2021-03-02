using System;
using System.IO;
using System.Text;

namespace Lesson5Project4
{
    class Lesson5Project4
    {
        static void Main(string[] args)
        {
            string path = null, fileName;

            Console.Write("Введите имя файла в который будет сохранена иерархия директорий: ");

            fileName = $"{Console.ReadLine()}.txt";

            do
            {
                if(path != null)
                    Console.WriteLine("Ошибка путь не сушествует.");

                Console.Write("Введите путь: ");
            }
            while (!Directory.Exists(path = Console.ReadLine()));


            using (StreamWriter writer = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write), Encoding.UTF8))
                WritePath(new DirectoryInfo(path), writer);


            Console.WriteLine($"Иерархия директорий записана в файл: {fileName}");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }

        static void WritePath(DirectoryInfo path, TextWriter stream, int tab = 0)
        {
            stream.WriteLine($"{new string('\t', tab)}{path.Name}");

            foreach (DirectoryInfo innerPath in path.GetDirectories())
                WritePath(innerPath, stream, tab + 1);
        }
    }
}
