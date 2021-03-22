using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7Project1
{
    class TicTacToe
    {

        public TicTacToe(int sizeX, int sizeY, int win)
        {
            if (sizeX <= 0 || sizeY <= 0 || win <= 0 || (win > sizeX && win > sizeY))
                throw new ArgumentException("ti eblan prover argumenti libo choto menishe 0 libo nikogda ne bydet ");

        }

    }
}
