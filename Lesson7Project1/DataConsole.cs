using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7Project1
{
    class DataConsole : Data
    {
        public readonly int x;
        public readonly int y;
        public readonly int sizeX;
        public readonly int sizeY;

        public readonly Symbol symbol;

        public DataConsole(int x, int y, int sizeX, int sizeY, Symbol symbol)
        {
            this.x = x;
            this.y = y;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.symbol = symbol;
        }
    }
}
