using System;

 class Employee
{
    private string _name;
    private double _salary;
    private string _ssn;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cant be empty");
            _name = value;
        }
    }

    public double Salary
    {
        get => _salary;
        private set => _salary = value; //Only settable inside this class
    }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public void GiveRise(double percent)
    {
        if (percent <= 0)
            throw new ArgumentException("Percentage must be pos");
        Salary *= (1 + percent / 100);
        Console.WriteLine($"{Name}'s new Salary: {Salary:C}");
    }
}

public static class EmployeeDemo
    {
        public static void Run()
            {
                Employee emp = new Employee("Mahin", 100000);
                emp.GiveRise(50);
        //emp.Salary = 200000; // This will cause a compile-time error because Salary has a private setter
        //emp._salary = 200000; // This will cause a compile-time error because _salary is private
    }
}