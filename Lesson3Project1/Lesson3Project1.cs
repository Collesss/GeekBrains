using System;

namespace Lesson3Project1
{
    class Lesson3Project1
    {
        static void Main(string[] args)
        {
            const int len = 5;
            int[,] twoDimArray = new int[len, len];

            for (int i = 0; i < twoDimArray.GetLength(0); i++)
                for (int j = 0; j < twoDimArray.GetLength(1); twoDimArray[i, j] = i * twoDimArray.GetLength(0) + j++);

            Console.Write("Элементы главной диагонали двумерного массива:");
            for (int i = 0; i < len; Console.Write($" {twoDimArray[i, i++], 2}"));
            Console.WriteLine(";");

            Console.Write("Элементы побочной диагонали двумерного массива:");
            for (int i = 0; i < len; Console.Write($" {twoDimArray[len - 1 - i, i++], 2}"));
            Console.WriteLine(";");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
