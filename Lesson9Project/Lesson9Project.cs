using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Lesson9Project
{
    class Lesson9Project
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(200, 50);
            Console.SetWindowSize(200, 50);


            //ConsoleDraw.DrawLine(0, 0, Direction.Vertical, 5);
            //ConsoleDraw.DrawLine(1, 0, Direction.Vertical, 5);
            //ConsoleDraw.DrawLine(190, 5, Direction.Horizontal, 20);

            //width input field 14
            
            ConsoleDraw.DrawRectangle1(0, 0, 24, 50);

            ConsoleDraw.DrawRectangle1(2, 44, 20, 5);

            Console.SetCursorPosition(5, 46);

            ConsoleKeyInfo pressKey;

            StringBuilder buffer = new StringBuilder();

            while (true)
            {
                pressKey = Console.ReadKey(true);

                if (pressKey.Key == ConsoleKey.Backspace && buffer.Length > 0)
                {
                    if (buffer.Length < 14)
                    {
                        ConsoleDraw.ClearCell(Console.CursorLeft - 1, 46);
                    }
                    else if (buffer.Length == 14)
                    {
                        ConsoleDraw.ClearCell(Console.CursorLeft, 46);
                    }
                    else
                    {
                        Console.MoveBufferArea(5, 46, 13, 1, 6, 46);
                        ConsoleDraw.DrawChar(5, 46, buffer[buffer.Length - 15], false);
                        Console.SetCursorPosition(18, 46);
                    }

                    buffer.Remove(buffer.Length - 1, 1);
                }
                else if (pressKey.Key != ConsoleKey.Backspace)
                {
                    buffer.Append(pressKey.KeyChar);

                    if (buffer.Length < 14)
                    {
                        ConsoleDraw.DrawChar(Console.CursorLeft, 46, pressKey.KeyChar);
                    }
                    else if (buffer.Length == 14)
                    {
                        ConsoleDraw.DrawChar(Console.CursorLeft, 46, pressKey.KeyChar, false);
                    }
                    else
                    {
                        Console.MoveBufferArea(6, 46, 13, 1, 5, 46);
                        ConsoleDraw.DrawChar(Console.CursorLeft, 46, pressKey.KeyChar, false);
                    }
                    
                }
            }


            Console.WriteLine(Console.BufferHeight);
            Console.WriteLine(Console.BufferWidth);
        }


        static void Test()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                foreach (MethodInfo methodBase in type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod))
                {


                    foreach (CustomAttributeData attributeData in methodBase.CustomAttributes)
                    {
                        Console.WriteLine($"{attributeData.AttributeType.Name}: {string.Join(", ", attributeData.AttributeType.GetFields(BindingFlags.Instance | BindingFlags.Public).Select(f => $"{f.FieldType.Name} {f.Name}"))}");
                        Console.WriteLine($"CA: {string.Join(", ", attributeData.ConstructorArguments.Select(ca => $"{ca.ArgumentType.Name}: {ca.Value}"))}");
                        Console.WriteLine($"NA: {string.Join(", ", attributeData.NamedArguments.Select(na => $"{na.TypedValue.ArgumentType.Name} {na.MemberName}: {na.TypedValue.Value}"))}");
                    }

                    Console.WriteLine($"{methodBase.ReturnType.Name} {methodBase.Name}({string.Join(", ", methodBase.GetParameters().Select(p => $"{p.ParameterType.Name} {p.Name}"))})");



                    object[] arg = new object[methodBase.GetParameters().Length];

                    foreach (ParameterInfo parameterInfo in methodBase.GetParameters())
                    {
                        arg[parameterInfo.Position] = parameterInfo.ParameterType.Name switch
                        {
                            "String" => null,
                            "Int32" => 0,
                            _ => null
                        };
                    }

                    Console.WriteLine(methodBase.Invoke(null, arg));


                    Console.WriteLine();
                }
            }

            Console.WriteLine("press any key...");
            Console.ReadKey();
        }
    }
}
