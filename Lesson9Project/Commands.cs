using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9Project
{
    public static class Commands
    {
        [Command("test")]
        public static string Cmd()
        {
            return "Cmd";
        }

        [Command("test1")]
        public static string Cmd1([Parametr("t1")] string test1)
        {
            return $"Cmd1: {test1}";
        }

        [Command("test2")]
        public static string Cmd2([Parametr("t1")] string test1, [Parametr("t1")] int test2)
        {
            return $"Cmd2: {test1}, {test2}";
        }

        [Command("test3")]
        public static void Cmd3([Parametr("t1")] string test1, [Parametr("t2")] int test2)
        {

        }
    }
}
