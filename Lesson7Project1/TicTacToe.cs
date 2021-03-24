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
            int startX = direction == Direction.Vertical ? x : Math.Clamp(0, field.GetLength(1), x - Win);
            int startY = direction == Direction.Horizontal ? y : Math.Clamp(0, field.GetLength(0), y + (direction == Direction.DiagonalSide ? Win : -Win));

            int incX = direction == Direction.Vertical ? 0 : 1;
            int incY = direction switch
            {
                Direction.Horizontal => 0,
                Direction.DiagonalSide => -1,
                _ => 1
            };

            int endX = direction == Direction.Vertical ? x : Math.Clamp(0, field.GetLength(1), x + Win);
            int endY = direction == Direction.Horizontal ? y : Math.Clamp(0, field.GetLength(0), y + (direction == Direction.DiagonalSide ? -Win : Win));



            int addNX = x - Win;
            int addNY = y - Win;

            if (addNX < 0 || addNY < 0)
            {
                
            }

            int addPX = x + Win;
            int addPY = y + Win;

            if (addPX >= field.GetLength(1) || addPY >= field.GetLength(0))
            {

            }


            switch (direction)
            {
                case Direction.DiagonalMain:
                    break;
                case Direction.DiagonalSide:
                    break;
            }
            

            int posLastX = startX;
            int posLastY = startY;
            int count = 0;

            


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
