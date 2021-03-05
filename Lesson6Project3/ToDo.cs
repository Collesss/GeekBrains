using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6Project3
{
    class ToDo
    {
        public bool IsDone;
        public string Title;

        public ToDo()
        {
            IsDone = false;
            Title = string.Empty;
        }

        public ToDo(string Title)
        {
            IsDone = false;
            this.Title = Title;
        }

        public ToDo(bool IsDone, string Title)
        {
            this.IsDone = IsDone;
            this.Title = Title;
        }

    }
}
