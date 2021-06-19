using System;
using System.Text;

namespace Lesson6Project5
{
    class Lesson6Project5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;

            Person[] people = { 
                new Person("test0", "pos0", "test0@test.test", "+7 123 456 78 90", 35_000, 20),
                new Person("test1", "pos1", "test1@test.test", "+7 123 456 78 91", 90_000, 50),
                new Person("test2", "pos2", "test2@test.test", "+7 123 456 78 92", 60_000, 40),
                new Person("test3", "pos3", "test3@test.test", "+7 123 456 78 93", 75_000, 45),
                new Person("test4", "pos4", "test4@test.test", "+7 123 456 78 94", 55_000, 33)
            };

            foreach(Person person in people)
                if(person.age > 40)
                    Console.WriteLine(person);

            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
    }
}
