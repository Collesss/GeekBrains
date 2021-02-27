using System;

namespace Lesson3Project4
{
    class Lesson3Project4
    {
        static void Main(string[] args)
        {
            char[,] battleField = new char[10, 10] {
                { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                { 'X', 'X', 'X', 'X', 'O', 'O', 'O', 'O', 'O', 'O' },
                { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O' },
                { 'X', 'X', 'X', 'O', 'O', 'O', 'X', 'O', 'X', 'O' },
                { 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O' },
                { 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                { 'O', 'O', 'X', 'O', 'O', 'O', 'X', 'X', 'O', 'O' },
                { 'X', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X' }
            };

            Console.WriteLine("Морской бой");

            for (int i = 0; i < battleField.GetLength(0); Console.WriteLine(), i++)
                for (int j = 0; j < battleField.GetLength(1); Console.Write($"{battleField[i, j++]} "));


            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
