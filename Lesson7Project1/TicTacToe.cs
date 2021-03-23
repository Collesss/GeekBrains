using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7Project1
{

    enum Symbol : sbyte
    {
        Cross =  1,
        Zero  = -1,
        Empty =  0,
        Error = sbyte.MaxValue
    }


    class TicTacToe
    {
        readonly static Dictionary<Symbol, char> symbolToChar = new Dictionary<Symbol, char>()
        {
            [Symbol.Empty]  = ' ',
            [Symbol.Cross]  = 'X',
            [Symbol.Zero]   = 'O'
        };

        private enum Direction
        {
            Vertical,
            Horizontal,
            DiagonalMain,
            DiagonalSide
        }

        public int SizeX { get; private set; }
        public int SizeY { get; private set; }
        public int Win { get; private set; }

        private Symbol[,] field;

        public TicTacToe(int sizeX, int sizeY, int win)
        {
            if (sizeX <= 0 || sizeY <= 0 || win <= 0 || (win > sizeX && win > sizeY))
                throw new ArgumentException("ti eblan prover argumenti libo choto menishe 0 libo nikogda ne bydet win");

            SizeX = sizeX;
            SizeY = sizeY;
            Win = win;

            field = new Symbol[sizeY, sizeX];

            Clear();
        }

        private void Clear()
        {
            for (int y = 0; y < field.GetLength(0); y++)
                for (int x = 0; x < field.GetLength(1); x++)
                    field[y, x] = Symbol.Empty;
        }


        public Symbol Move(Symbol player, int x, int y)
        {
            if (!(Math.InRange(0, field.GetLength(0), y) && Math.InRange(0, field.GetLength(1), x)) || ((int)(player & (Symbol.Cross | Symbol.Zero))) == 0 || field[y, x] != Symbol.Empty)
                return Symbol.Error;

            field[y, x] = player;



        }

        private Symbol Check(int x, int y, Direction direction)
        {
            int startX, startY;

            startX = Math.Clamp(0, field.GetLength(1), x - Win);
            startY = Math.Clamp(0, field.GetLength(0), y - Win);
            
            startX = direction == Direction.Vertical ? x : Math.Clamp(0, field.GetLength(1), x - Win);
            

            switch (direction)
            {
                case Direction.Horizontal:
                    startY = y;
                    break;
                case Direction.Vertical:
                    startX = x;
                    break;
                case Direction.DiagonalSide:
                    startY = Math.Clamp(0, field.GetLength(0), y + Win);
                    break;
            }

            /*
            int startX = direction switch 
            {
                Direction.Horizontal => Math.Clamp(0, field.GetLength(1), x - Win),
                Direction.Vertical => x,
                Direction.DiagonalMain => Math.Clamp(0, field.GetLength(1), x - Win),
                Direction.DiagonalSide => Math.Clamp(0, field.GetLength(1), x - Win),
                _ => 0
            };
            int startY = direction switch
            {
                Direction.Horizontal => y,
                Direction.Vertical => Math.Clamp(0, field.GetLength(0), y - Win),
                Direction.DiagonalMain => Math.Clamp(0, field.GetLength(0), y - Win),
                Direction.DiagonalSide => Math.Clamp(0, field.GetLength(0), y + Win),
                _ => 0
            };
            */

        }

    }
}
