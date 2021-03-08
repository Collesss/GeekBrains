using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6Project4
{
    class ArraySizeException : Exception
    {
        public string error;

        public ArraySizeException() =>
            error = "Ошибка несоответствия размера массива";

        public ArraySizeException(string error) =>
            this.error = error;
    }
}
