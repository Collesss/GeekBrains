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

        public ShowConsole()
        {
            
        }

        void IShow.Show(Symbol[,] field)
        {
            Console.Clear();

            for (int y = 0; y < field.GetLength(0); y++)
            {
                for (int x = 0; x < field.GetLength(1); x++)
                {

                }
            }
        }
    }
}
