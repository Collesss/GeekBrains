using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9Project
{
    static class HelpClass
    {
        public static bool ToNum(ref int value, int toVal, int step = 0)
        {
            if (value == toVal)
                return true;


            step = Math.Abs(step);
            int chek = Math.Abs(toVal - value);

            value = chek < step ? toVal : (value > toVal ? value - step : value + step);

            return false;
        }

        public static int ToZero(int val) => val - Math.Sign(val);

        public static bool InRange(int val, int min, int max) => val >= min && val <= max;

        public static bool IsArrow(ConsoleKey key) => InRange((int)key, 37, 40);
    }
}
