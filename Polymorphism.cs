using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
    public string Add(string a, string b)
    {
        return a + b;
    }
}

public static class CompileTimePolymorphism
{
    public static void Run()
    {
        Calculator calculator = new Calculator();
        int sumInt = calculator.Add(5, 10);
        Console.WriteLine("Sum of integers: " + sumInt);
        double sumDouble = calculator.Add(5.5, 10.3);
        Console.WriteLine("Sum of doubles: " + sumDouble);
        string sumString = calculator.Add("Hello, ", "World!");
        Console.WriteLine("Concatenated string: " + sumString);
    }
}