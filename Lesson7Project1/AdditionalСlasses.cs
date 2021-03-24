using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7Project1
{
    static class Math
    {
        public static bool InRange(int min, int max, int value) =>
            value >= min && value <= max;

        public static int Clamp(int min, int max, int value) => 
            value < min ? min : (value > max ? max : value);

        public static bool ToNum(int toNum, ref int value)
        {
            if (value != toNum)
            {
                value += value > toNum ? -1 : 1;

                return true;
            }

            return false;
        }
    }
}
