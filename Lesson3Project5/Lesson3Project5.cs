using System;

namespace Lesson3Project5
{
    class Lesson3Project5
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[len];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("Введите смещение массива: ");
            int offset = Convert.ToInt32(Console.ReadLine());

            offset = (arr.Length + offset % arr.Length) % arr.Length;

            int num = arr[0];

            for (int i = 0, p = 0, index = offset; i < arr.Length; i++)
            {
                int numNext = arr[index];
                arr[index] = num;
                num = numNext;

                if (index == p)
                {
                    p++;
                    index++;
                    num = arr[index];
                }

                index = (index + offset) % arr.Length;
            }

            
            Console.WriteLine("Вывод массива с круговым смещением: ");

            for (int i = 0; i < arr.Length; Console.WriteLine($"{i} элемент массива: {arr[i++]}"));

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
