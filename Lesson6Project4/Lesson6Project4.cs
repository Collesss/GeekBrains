using System;

namespace Lesson6Project4
{
    class Lesson6Project4
    {
        const int size = 4;

        static void Main(string[] args)
        {
            string[][,] arr = {
                new string[,]{
                    {"0", "1", "2" },
                    {"3", "4", "5" },
                    {"6", "7", "8" }
                },
                new string[,]{
                    {"0", "1", "2", "3" },
                    {"4", "5", "6", "7" },
                    {"8", "9", "1O", "11" },
                    {"12", "13", "14", "15" }
                },
                new string[,]{
                    {"0", "1", "2", "3" },
                    {"4", "5", "6", "7" },
                    {"8", "9", "10", "11" },
                    {"12", "13", "14", "15" }
                }
            };

            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    Console.WriteLine($"Сумма элементов массива равна: {Sum(arr[i])};");
                }
                catch (ArraySizeException)
                {
                    Console.WriteLine($"{i}: при подсчёте суммы элементов массива произошла ошибка, размер массива не соответвует требуемому.");
                }
                catch (ArrayDataException e)
                {
                    Console.WriteLine($"{i}: при подсчёте суммы элементов массива произошла ошибка конвертации в ячейке с координатами x: {e.x}; y: {e.y};");
                }
            }

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }

        static int Sum(string[,] arr)
        {
            if (arr.GetLength(0) != size || arr.GetLength(1) != size)
                throw new ArraySizeException();

            int sum = 0;

            for (int y = 0; y < size; y++)
                for (int x = 0; x < size; x++)
                {
                    try
                    {
                        sum += Int32.Parse(arr[y, x]);
                    }
                    catch (FormatException e)
                    {
                        throw new ArrayDataException(x, y, e);
                    }
                }

            return sum;
        }
    }
}
