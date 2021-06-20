using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lesson8Project1
{
    class Lesson8Project1
    {

        static Dictionary<string, Action> command = new Dictionary<string, Action>()
        {
            ["list"] = ProccessList,
            ["kill"] = ProccessKill,
        };

        static void Main(string[] args)
        {
            string com;

            do
            {
                com = Console.ReadLine().ToLower();

                if (command.TryGetValue(com, out Action Func))
                    Func();


            } while (com != "exit");


            Console.WriteLine("press any key...");
            Console.ReadKey();
        }


        public static void ProccessList()
        {
            Console.Clear();
            Console.WriteLine($"{"Id", 6}{"ProcessName", 40}{"Priority", 9}{"Memory", 35}");
            foreach (Process process in Process.GetProcesses())
                Console.WriteLine($"{process.Id, 6}{process.ProcessName, 40}{process.BasePriority, 9}{process.VirtualMemorySize64, 35}");
        }

        public static void ProccessKill()
        {
            int proccesId;
            string str;

            do
            {
                Console.WriteLine("enter process ID or exit");
                str = Console.ReadLine().ToLower();
            } while (Int32.TryParse(str, out proccesId) ^ str != "exit");

            if(str != "exit")
            {
                if (SearchProcess(proccesId, out Process process))
                {
                    process.Kill();
                    Console.WriteLine($"process {proccesId} killed.");
                }
                else
                    Console.WriteLine("process not find.");
            }
        }

        public static bool SearchProcess(int id, out Process process)
        {
            foreach (Process proc in Process.GetProcesses())
                if (proc.Id == id)
                {
                    process = proc;
                    return true;
                }
            
            process = Process.GetCurrentProcess();
            return false;
        }

    }
}
