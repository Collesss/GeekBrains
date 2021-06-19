using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Lesson6Project2
{
    class Lesson6Project2
    {
        static void Main(string[] args)
        {
            string path = null, fileName;

            Console.Write("Введите имя файла в который будет сохранена иерархия директорий: ");

            fileName = $"{Console.ReadLine()}.txt";

            do
            {
                if (path != null)
                    Console.WriteLine("Ошибка путь не сушествует.");

                Console.Write("Введите путь: ");
            }
            while (!Directory.Exists(path = Console.ReadLine()));

            using (StreamWriter writer = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write), Encoding.UTF8))
                WritePath(new DirectoryInfo(path), writer);

            Console.WriteLine($"Иерархия директорий записана в файл: {fileName}");

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }

        static void WritePath(DirectoryInfo path, TextWriter stream)
        {
            void Write(string path, int tabs) =>
                stream.WriteLine($"{new string('\t', tabs)}{path}");

            Stack<int> positions = new Stack<int>();
            Stack<DirectoryInfo> directoryInfos = new Stack<DirectoryInfo>();

            int depthTabs = 1, curIndex = 0;

            DirectoryInfo curPath = path;

            do
            {
                if(curIndex == 0)
                    Write(curPath.Name, depthTabs - 1);

                if (curIndex < curPath.GetDirectories().Length)
                {
                    depthTabs++;
                    positions.Push(curIndex + 1);
                    directoryInfos.Push(curPath);
                    curPath = curPath.GetDirectories()[curIndex];
                    curIndex = 0;
                }
                else
                {
                    foreach (FileInfo fileInfo in curPath.GetFiles())
                        Write(fileInfo.Name, depthTabs);

                    if (positions.Count > 0)
                    {
                        curIndex = positions.Pop();
                        curPath = directoryInfos.Pop();
                    }

                    depthTabs--;
                }
            }
            while (depthTabs > 0);
        }

        /*
        static void WritePath(DirectoryInfo path, TextWriter stream)
        {
            int Search(DirectoryInfo[] strs, DirectoryInfo searchStr)
            {
                for (int i = 0; i < strs.Length; i++)
                    if (strs[i].FullName == searchStr.FullName)
                        return i;
                return -1;
            }

            int depthTabs = 1, curIndex = 0;

            do
            {
                stream.WriteLine($"{new string('\t', depthTabs - 1)}{path.Name}");

                DirectoryInfo[] directoryInfos = path.GetDirectories();

                if (directoryInfos.Length > 0)
                {
                    curIndex = 0;
                    depthTabs++;
                    path = directoryInfos[0];
                }
                else
                {
                    foreach (FileInfo fileInfo in path.GetFiles())
                        stream.WriteLine($"{new string('\t', depthTabs)}{fileInfo.Name}");

                    if (++curIndex < (directoryInfos = path.Parent.GetDirectories()).Length)
                        path = directoryInfos[curIndex];
                    else
                    {
                        for (DirectoryInfo parent = path.Parent; --depthTabs > 1; parent = parent.Parent)
                        {
                            foreach (FileInfo fileInfo in parent.GetFiles())
                                stream.WriteLine($"{new string('\t', depthTabs - 1)}{fileInfo.Name}");

                            DirectoryInfo[] parentDirs = parent.Parent.GetDirectories();

                            curIndex = Search(parentDirs, parent);

                            if (++curIndex < parentDirs.Length)
                            {
                                path = parentDirs[curIndex];
                                break;
                            }
                        }
                    }
                }
            } while (depthTabs > 1);
        }*/
    }
}
