﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9Project
{
    class InputField
    {
        private readonly int posLeft;
        private readonly int posTop;
        private readonly int width;
        private readonly int countGhostChar;

        private int posCursorField = 0;
        private int posCursorBuffer = 0;

        public InputField(int posLeft, int posTop, int width, int countGhostChar)
        {
            this.posLeft = posLeft;
            this.posTop = posTop;
            this.width = width;
            this.countGhostChar = countGhostChar;
        }


        public string GetString()
        {
            Console.SetCursorPosition(posLeft, posTop);

            ConsoleKeyInfo pressKey;

            StringBuilder buffer = new StringBuilder();

            while (true)
            {
                pressKey = Console.ReadKey(true);

                if (HelpClass.IsArrow(pressKey.Key))
                {
                    switch (pressKey.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (posCursorField > 0)
                            {
                                posCursorField--;
                                Console.SetCursorPosition(posLeft + posCursorField, posTop);
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (posCursorField < width && posCursorField < buffer.Length)
                            {
                                posCursorField++;
                                Console.SetCursorPosition(posLeft + posCursorField, posTop);
                            }
                            break;
                    }
                }
                else if (pressKey.Key == ConsoleKey.Enter)
                {
                    ConsoleDraw.ClearLine(posLeft, posTop, Direction.Horizontal, width);
                    break;
                }
                else if (pressKey.Key == ConsoleKey.Backspace && buffer.Length > 0)
                {
                    if (buffer.Length <= width)
                    {
                        ConsoleDraw.ClearCell(Console.CursorLeft - (buffer.Length == width ? 0 : 1), posTop);

                        if (buffer.Length != width)
                            posCursorField--;
                    }
                    else
                    {
                        Console.MoveBufferArea(posLeft, posTop, width - 1, 1, posLeft + 1, posTop);
                        ConsoleDraw.DrawChar(posLeft, posTop, buffer[buffer.Length - 15], false);
                        Console.SetCursorPosition(posLeft + width - 1, posTop);
                    }

                    buffer.Remove(buffer.Length - 1, 1);
                }
                else if (pressKey.Key != ConsoleKey.Backspace)
                {
                    buffer.Append(pressKey.KeyChar);

                    if (buffer.Length <= width)
                    {
                        ConsoleDraw.DrawChar(Console.CursorLeft, posTop, pressKey.KeyChar, buffer.Length != width);

                        if (buffer.Length != width)
                            posCursorField++;
                    }
                    else
                    {
                        Console.MoveBufferArea(posLeft + 1, posTop, width - 1, 1, posLeft, posTop);
                        ConsoleDraw.DrawChar(Console.CursorLeft, posTop, pressKey.KeyChar, false);
                    }
                }
            }

            return buffer.ToString();
        }
    }
}