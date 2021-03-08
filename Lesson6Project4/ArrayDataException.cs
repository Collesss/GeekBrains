using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6Project4
{
    class ArrayDataException : Exception
    {
        public string error;
        public int x;
        public int y;

        public ArrayDataException()
        {
            error = "Ошибка при приведении типов";
            x = y = 0;
        }

        public ArrayDataException(string error) : this() =>
            this.error = error;

        public ArrayDataException(int x, int y) : this()
        {
            this.x = x;
            this.y = y;
        }

        public ArrayDataException(int x, int y, Exception innerException) : base(innerException.Message, innerException)
        {
            error = "Ошибка при приведении типов";
            this.x = x;
            this.y = y;
        }

        public ArrayDataException(string error, int x, int y)
        {
            this.error = error;
            this.x = x;
            this.y = y;
        }
    }
}
