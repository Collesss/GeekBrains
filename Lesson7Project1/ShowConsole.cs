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

        readonly static ValueConditional<DataConsole, char> valueConditional;

        static ShowConsole()
        {
            valueConditional = new ValueConditional<DataConsole, char>(' ', 
                (DataConsole data, out char outval) => { //1
                    outval = '\0';
                    if (data.y == 0 && data.x == 0)
                    {
                        outval = '\u250C';
                        return true;
                    }
                    return false;
                },
                (DataConsole data, out char outval) => { //2
                    outval = '\0';
                    if (data.y == 0 && data.x == data.sizeX)
                    {
                        outval = '\u2510';
                        return true;
                    }
                    return false;
                },
                (DataConsole data, out char outval) => { //3
                    outval = '\0';
                    if (data.y == data.sizeY && data.x == 0)
                    {
                        outval = '\u2514';
                        return true;
                    }
                    return false;
                },
                (DataConsole data, out char outval) => { //4
                    outval = '\0';
                    if (data.y == data.sizeY && data.x == data.sizeX)
                    {
                        outval = '\u2518';
                        return true;
                    }
                    return false;
                },
                (DataConsole data, out char outval) => { //5
                    outval = '\0';
                    if (data.y % 2 == 0 && data.x == 0)
                    {
                        outval = '\u251C';
                        return true;
                    }
                    return false;
                },
                (DataConsole data, out char outval) => { //6
                    outval = '\0';
                    if (data.y % 2 == 0 && data.x == data.sizeX)
                    {
                        outval = '\u2524';
                        return true;
                    }
                    return false;
                },
                (DataConsole data, out char outval) => { //7
                    outval = '\0';
                    if (data.y == 0 && data.x % 4 == 0)
                    {
                        outval = '\u252C';
                        return true;
                    }
                    return false;
                },
                (DataConsole data, out char outval) => { //8
                    outval = '\0';
                    if (data.y == data.sizeY && data.x % 4 == 0)
                    {
                        outval = '\u2534';
                        return true;
                    }
                    return false;
                },
                (DataConsole data, out char outval) => { //9
                    outval = '\0';
                    if (data.y % 2 == 0 && data.x % 4 == 0)
                    {
                        outval = '\u253C';
                        return true;
                    }
                    return false;
                },
                (DataConsole data, out char outval) => { //10
                    outval = '\0';
                    if (data.y % 2 != 0 && (data.x - 2) % 4 == 0)
                    {
                        outval = symbolToChar[data.symbol];
                        return true;
                    }
                    return false;
                },
                (DataConsole data, out char outval) => { //11
                    outval = '\0';
                    if (data.y % 2 == 0)
                    {
                        outval = '\u2500';
                        return true;
                    }
                    return false;
                },
                (DataConsole data, out char outval) => { //12
                    outval = '\0';
                    if (data.x % 4 == 0)
                    {
                        outval = '\u2502';
                        return true;
                    }
                    return false;
                });
        }

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
                    Console.Write(valueConditional.Check(new DataConsole(x, y, field.GetLength(1) * 4, field.GetLength(0) * 2, y % 2 != 0 && (x - 2) % 4 == 0 ? field[(y - 1) / 2, (x - 2) / 4] : Symbol.Error)));
                    /*
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
                    */
                }

                Console.WriteLine();
            }

            Console.CursorVisible = true;
        }
    }
}
