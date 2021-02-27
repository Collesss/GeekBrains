using System;

namespace Lesson4Project4
{
    class Lesson4Project4
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер числа Фибоначи: ");

            int num;

            string inputStr = null;

            do
            {
                if (inputStr != null)
                    Console.WriteLine("Неверный ввод попробуйте снова.");

                Console.Write("Введите номер числа Фибоначи (больше 0): ");
            }
            while (!Int32.TryParse(inputStr = Console.ReadLine(), out num) || !(num > 0));

            Console.WriteLine($"Число Фибоначи с номером {num} равно: {Fibonachi(num)}");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }


        static int Fibonachi(int n) =>
            n <= 2 ? n - 1 : Fibonachi(n - 2) + Fibonachi(n - 1);
    }
}
