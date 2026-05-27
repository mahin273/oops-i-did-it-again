using System;
using System.Xml.Serialization;

namespace OopsExamples
{
    //Level 1 - most general
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(string name,string email)
        {
            Name = name;
            Email = email;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}");
        }
    }

    //Leve 2 - more specific
    class Employee : Person
    {
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name,string email,string dept,decimal salary) : base(name, email)
        {
            Department = dept;
            Salary = salary;
        }

        public new void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I work in {Department}");
        }
    }

    //Level 3 - most specific
    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name,string email,string dept,decimal salary,int teamSize) : base(name, email, dept, salary)
        {
            TeamSize = teamSize;
        }

        public new void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I manage a team of {TeamSize}");
        }
    }

    public static class PersonDemo
    {
        public static void Run()
        {
            Manager m = new Manager("Mahin", "mahin@dev.io", "Engineering", 120000m, 8);
            m.Introduce();

        }
    }
}
