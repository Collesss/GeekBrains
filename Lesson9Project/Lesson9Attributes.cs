using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9Project
{
    
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    sealed class CommandAttribute : Attribute
    {
        public readonly string command;

        public CommandAttribute(string command)
        {
            this.command = command;
        }
    }

    [AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
    sealed class ParametrAttribute : Attribute
    {
        public readonly string paramName;

        public ParametrAttribute(string paramName)
        {
            this.paramName = paramName;
        }
    }
}
