
namespace Lesson6Project5
{
    class Person
    {
        //ФИО, должность, email, телефон, зарплата, возраст

        public string name;
        public string position;
        public string email;
        public string telephone;
        public double salary;
        public int age;

        public Person(string name, string position, string email, string telephone, double salary, int age)
        {
            this.name = name;
            this.position = position;
            this.email = email;
            this.telephone = telephone;
            this.salary = salary;
            this.age = age;
        }

        public override string ToString() =>
            $"ФИО: {name}; Должность: {position}; Email: {email}; Телефон: {telephone}; Зарплата: {salary:C2}; Возраст: {age};";
    }
}
