using System;

namespace Lesson7Project1
{
    class Lesson7Project1
    {
        static void Main(string[] args)
        {
            TicTacToe ticTacToe = new TicTacToe(4, 4, 3, new ShowConsole(0, 0));

            //работает

            Symbol s1 = ticTacToe.Move(Symbol.Cross, 0, 0);
            Symbol s2 = ticTacToe.Move(Symbol.Cross, 1, 0);
            Symbol s3 = ticTacToe.Move(Symbol.Zero, 1, 1);
            Symbol s4 = ticTacToe.Move(Symbol.Cross, 2, 0);

        }
    }
}
