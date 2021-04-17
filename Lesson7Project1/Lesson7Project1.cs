using System;

namespace Lesson7Project1
{
    class Lesson7Project1
    {
        static TicTacToe ticTacToe;
        static ShowConsole showConsole = new ShowConsole(0, 0);
        static Symbol whoWalk = Symbol.Cross;
        static Random random = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                GetGame();

                while (true)
                {
                    Symbol retVal = Symbol.Empty;

                    (int x, int y) coord;

                    do
                    {
                        if(retVal == Symbol.Error)
                            Console.WriteLine("Ошибка введите другие кординаты.");

                        coord = GetCoord();
                    }
                    while ((retVal = ticTacToe.Move(whoWalk, coord.x, coord.y)) == Symbol.Error);

                    whoWalk = whoWalk switch {
                        Symbol.Cross => Symbol.Zero,
                        Symbol.Zero => Symbol.Cross,
                        _ => Symbol.Error
                    };

                    if (retVal != Symbol.Empty)
                    {
                        Console.WriteLine($"Победитель: {retVal}");

                        break;
                    }
                }
            }

        }

        static (int x, int y) GetCoord()
        {
            if (whoWalk == Symbol.Zero)
                return (random.Next(0, ticTacToe.SizeX), random.Next(0, ticTacToe.SizeY));

            int x, y;

            while (true)
            {
                try
                {
                    Console.Write("Введите координату x: ");
                    x = Int32.Parse(Console.ReadLine());
                    Console.Write("Введите координату y: ");
                    y = Int32.Parse(Console.ReadLine());

                    break;
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("Ошибка преобразования.");
                }
            }


            return (x, y);
        }

        static void GetGame()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите ширину поля: ");
                    int x = Int32.Parse(Console.ReadLine());
                    Console.Write("Введите высоту поля: ");
                    int y = Int32.Parse(Console.ReadLine());
                    Console.Write("Введите количество последовтельно идущих символов для победы: ");
                    int size = Int32.Parse(Console.ReadLine());


                    ticTacToe = new TicTacToe(x, y, size, showConsole);

                    break;
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("Ошибка преобразования.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Ошибка при создании поля.");
                }
            }

            whoWalk = Symbol.Cross;
        }
    }
}
