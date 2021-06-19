using System;
using System.IO;

namespace Lesson5Project3
{
    class Lesson5Project3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя файла: ");
            string fileName = $"{Console.ReadLine()}.bin";
            Console.WriteLine($"Данные будут записаны в файл: {fileName}");

            using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
            {
                while (true)
                {
                    Console.Write("Введите число от 0 до 255 включительно, или q для выхода: ");

                    string inputStr;

                    if ((inputStr = Console.ReadLine()) == "q")
                        break;

                    if (byte.TryParse(inputStr, out byte res))
                    {
                        binaryWriter.Write(res);
                        Console.WriteLine($"Число {res,3} записано в файл.");
                    }
                    else
                        Console.WriteLine("Неверный ввод.");
                }
            }            

            Console.WriteLine($"Данные записаны в файл: {fileName}");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
