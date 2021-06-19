using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Lesson6Project3
{
    class Lesson6Project3
    {
        const string nameFile = "tasks.xml";

        static void Main(string[] args)
        {
            List<ToDo> tasks = ReadToDo();

            string input = null;

            do
            {
                Console.WriteLine("Список задач: ");

                for (int i = 0; i < tasks.Count; Console.WriteLine($"{i} {tasks[i++]}")) ;

                Console.Write("Введите команду или help для получения инф. по командам: ");

                switch (input = Console.ReadLine().ToLower())
                {
                    case "mark":
                        Console.Write("Введите номер задачи для установки или сброса отметки: ");
                        if (Int32.TryParse(Console.ReadLine(), out int res) && res < tasks.Count)
                            tasks[res].IsDone = !tasks[res].IsDone;
                        else
                            Console.WriteLine("Введено не число или введённый неверный номер задачи.");
                        break;
                    case "delete":
                        Console.Write("Введите номер задачи для её удаления: ");
                        if (Int32.TryParse(Console.ReadLine(), out int res1) && res1 < tasks.Count)
                            tasks.RemoveAt(res1);
                        else
                            Console.WriteLine("Введено не число или введённый неверный номер задачи.");
                        break;
                    case "add":
                        Console.Write("Введите текст задачи: ");
                        tasks.Add(new ToDo(Console.ReadLine()));
                        break;
                    case "help":
                        Console.WriteLine("Введите mark для установки удаления отметки у задачи, delete для удаления задачи, add для добавление задачи, exit для выхода из программы");
                        break;
                    case "exit":
                        Console.WriteLine("Сохранение задач в файл и выход из программы.");
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда попробуйте снова.");
                        break;
                }
            } while (input != "exit");

            WriteToDo(tasks);

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }

        static List<ToDo> ReadToDo()
        {
            if (!File.Exists(nameFile))
                return new List<ToDo>();

            using (FileStream fs = new FileStream(nameFile, FileMode.Open, FileAccess.Read))
                return (List<ToDo>)new XmlSerializer(typeof(List<ToDo>)).Deserialize(fs);
        }

        static void WriteToDo(List<ToDo> tasks)
        {
            using (FileStream fs = new FileStream(nameFile, FileMode.Create, FileAccess.Write))
                new XmlSerializer(typeof(List<ToDo>)).Serialize(fs, tasks);
        }
    }
}