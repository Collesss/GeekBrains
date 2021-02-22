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

            //bool oLOR = offset > 0; 

            for (int i = offset > 0 ? arr.Length - 1 - offset : -offset; offset > 0 ? i >= 0 : i < arr.Length; i += offset > 0 ? -1 : 1)
            {
                arr[i + offset] = arr[i];
                arr[i] = 0;
            }

            Console.WriteLine("Вывод массива со смещением: ");

            for (int i = 0; i < arr.Length; Console.WriteLine($"{i} элемент массива: {arr[i++]}"));

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
