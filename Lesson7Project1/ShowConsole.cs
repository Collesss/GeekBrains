using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7Project1
{
    class ShowConsole : IShow
    {
        readonly static Dictionary<Symbol, char> symbolToChar = new Dictionary<Symbol, char>()
        {
            [Symbol.Empty] = ' ',
            [Symbol.Cross] = 'X',
            [Symbol.Zero] = 'O'
        };

        private int offsetX;
        private int offsetY;

        public ShowConsole(int offsetX, int offsetY)
        {
            this.offsetX = offsetX;
            this.offsetY = offsetY;
        }

        void IShow.Show(Symbol[,] field)
        {
            Console.CursorVisible = false;
            Console.Clear();

            for (int y = 0; y < field.GetLength(0) * 2 + 1; y++)
            {
                for (int x = 0; x < field.GetLength(1) * 4 + 1; x++)
                {
                    if (y == 0 && x == 0)//1 углы
                        Console.Write('\u250C');
                    else if (y == 0 && x == field.GetLength(1) * 4)
                        Console.Write('\u2510');
                    else if (y == field.GetLength(0) * 2 && x == 0)
                        Console.Write('\u2514');
                    else if (y == field.GetLength(0) * 2 && x == field.GetLength(1) * 4)
                        Console.Write('\u2518');//1
                    else if (y % 2 == 0 && x == 0)//2 3 - ветви стороны
                        Console.Write('\u251C');
                    else if (y % 2 == 0 && x == field.GetLength(1) * 4)
                        Console.Write('\u2524');
                    else if (y == 0 && x % 4 == 0)
                        Console.Write('\u252C');
                    else if (y == field.GetLength(0) * 2 && x % 4 == 0)
                        Console.Write('\u2534');//2
                    else if (y % 2 == 0 && x % 4 == 0)//3
                        Console.Write('\u253C');//3
                    else if (y % 2 != 0 && (x - 2) % 4 == 0)//4
                        Console.Write(symbolToChar[field[(y - 1) / 2, (x - 2) / 4]]);//4
                    else if (y % 2 == 0)//5
                        Console.Write('\u2500');
                    else if (x % 4 == 0)
                        Console.Write('\u2502');//5
                    else
                        Console.Write(' ');
                }

                Console.WriteLine();
            }

            Console.CursorVisible = true;
        }
    }
}
