using System;
using System.IO;
using System.Text;

namespace Lesson5Project5
{
    class Lesson5Project5
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
            int Search(DirectoryInfo[] strs, DirectoryInfo searchStr)
            {
                for (int i = 0; i < strs.Length; i++)
                    if (strs[i].FullName == searchStr.FullName)
                        return i;
                return -1;
            }

            int depthTabs = 1, curIndex = 0;

            DirectoryInfo curDirInfo = path;

            do
            {
                stream.WriteLine($"{new string('\t', depthTabs - 1)}{curDirInfo.Name}");

                DirectoryInfo[] directoryInfos = curDirInfo.GetDirectories();

                if (directoryInfos.Length > 0)
                {
                    curIndex = 0;
                    depthTabs++;
                    curDirInfo = directoryInfos[0];
                }
                else
                {
                    DirectoryInfo[] directoryInfosParent = curDirInfo.Parent.GetDirectories();

                    if (++curIndex < directoryInfosParent.Length)
                        curDirInfo = directoryInfosParent[curIndex];
                    else
                    {
                        for (DirectoryInfo parent = curDirInfo.Parent; --depthTabs > 1; parent = parent.Parent)
                        {
                            DirectoryInfo[] parentDirs = parent.Parent.GetDirectories();

                            curIndex = Search(parentDirs, parent);

                            if (++curIndex < parentDirs.Length)
                            {
                                curDirInfo = parentDirs[curIndex];
                                break;
                            }
                        }
                    }
                }
            } while (depthTabs > 1);

        }
    }
}
