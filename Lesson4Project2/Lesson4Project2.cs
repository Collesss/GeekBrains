using System;

namespace Lesson4Project2
{
    class Lesson4Project2
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа разделяя их пробелом: ");

            Console.WriteLine($"Сумма введённых чисел: {SumNumInString(Console.ReadLine())}");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }


        static int SumNumInString(string inputStr)
        {
            string[] numsStr = inputStr.Split(' ');

            int sum = 0;

            foreach (string numStr in numsStr)
                sum += Convert.ToInt32(numStr);

            return sum;
        }
    }
}
