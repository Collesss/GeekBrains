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
            ConsoleDraw.DrawRectangle1(2, 1, 20, 42);

            ConsoleDraw.DrawRectangle1(2, 44, 20, 5);

            InputField inputField = new InputField(5, 46, 14, 2);

            inputField.GetString();

            Console.WriteLine(inputField.GetString());

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
