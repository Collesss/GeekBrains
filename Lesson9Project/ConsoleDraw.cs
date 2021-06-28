using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9Project
{
    public static class ConsoleDraw
    {

        private static Dictionary<Direction, char> charTo = new Dictionary<Direction, char>() 
        {
            [Direction.Horizontal] = '\u2500',
            [Direction.Vertical] = '\u2502'
        };


        public static void DrawRectangle1(int x, int y, int sizeX, int sizeY)
        {
            if (sizeX < 2 || sizeY < 2)
                return;

            sizeX--;
            sizeY--;

            DrawChar(x, y, '\u250C');
            DrawChar(x + sizeX, y, '\u2510');
            DrawChar(x, y + sizeY, '\u2514');
            DrawChar(x + sizeX, y + sizeY, '\u2518');

            DrawLine(x + 1, y, Direction.Horizontal, sizeX - 1);
            DrawLine(x + 1, y + sizeY, Direction.Horizontal, sizeX - 1);
            DrawLine(x, y + 1, Direction.Vertical, sizeY - 1);
            DrawLine(x + sizeX, y + 1, Direction.Vertical, sizeY - 1);


            //DownAndRight  '\u250C'
            //DownAndLeft   '\u2510'
            //UpAndRight    '\u2514'
            //UpAndLeft     '\u2518'
        }


        public static void DrawRectangle2(int x1, int y1, int x2, int y2)
        {

            

        }

        public static void DrawLine(int x, int y, Direction direction, int size) =>
            DrawLine(x, y, direction, size, charTo[direction]);


        public static void DrawLine(int x, int y, Direction direction, int size, char @char)
        {
            int startPosVal = direction switch
            {
                Direction.Vertical => y,
                Direction.Horizontal => x
            };

            int endPosVal = startPosVal + size;

            for (int inc = Math.Sign(size); startPosVal != endPosVal; startPosVal += inc)
            {
                (int cx, int cy) = direction switch
                {
                    Direction.Horizontal => (startPosVal, y),
                    Direction.Vertical => (x, startPosVal)
                };

                DrawChar(cx, cy, @char);
            }
        }


        public static void DrawChar(int x, int y, char c, bool moveCurs = true)
        {
            if (x < 0 || x > Console.WindowWidth - 1 || y < 0 || y > Console.WindowHeight - 1)
                return;

            Console.SetCursorPosition(x, y);
            Console.Write(c);

            if(!moveCurs)
                Console.SetCursorPosition(x, y);
        }

        public static void ClearLine(int x, int y, Direction direction, int size)
        {
            DrawLine(x, y, direction, size, ' ');

            if (x > 0 && x < Console.WindowWidth && y > 0 && y < Console.WindowHeight)
                Console.SetCursorPosition(x, y);
        }

        public static void ClearCell(int x, int y) =>
            DrawChar(x, y, ' ', false);

        public static void DrawCharColor(int x, int y, char c, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
            Console.ResetColor();
        }

        public static void DrawCharColorAndBack(int x, int y, char c, ConsoleColor charColor, ConsoleColor bakColor)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = charColor;
            Console.BackgroundColor = charColor;
            Console.Write(c);
            Console.ResetColor();
        }
    }

    public enum Direction
    {
        Vertical = 0,
        Horizontal = 1
    }
}
