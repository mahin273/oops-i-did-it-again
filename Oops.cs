using System;
using System.Runtime.InteropServices;



public class Car
{
    //Fields - data the class hold
    public string Brand;
    public int Speed;

    /*
     *     Constructor - a special method that runs automatically when you
     *     create an object.it used to set initial Values
     */

    //Costructor - same name as class, no return type
    public Car(String brand)
    {
        Brand = brand;
        Speed = 0;
        Console.WriteLine($"{Brand} created!");
    }

    //Overload constructor
    public Car(string brand,int initialSpeed)
    {
        Brand = "brand";
        Speed = initialSpeed;
    }


    //Method - behavior the class has
    public void Acclerate(int amount)
    {
        Speed += amount;
        Console.WriteLine($"{Brand} acclerated. Speed:{Speed}");
    }

    public void Brake()
    {
        Speed = 0;
        Console.WriteLine($"{Brand} stopped.");
    }

  
}
public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
    }
}
public static class CarDemo
{
    public static void Run()
    {
        //Car myCar = new Car();
        //myCar.Brand = "Audi";
        //myCar.Speed = 100;
        //myCar.Acclerate(50);
        //myCar.Brake();
        Car car1 = new Car("Toyota");           // Toyota created!
        Car car2 = new Car("Honda", 30);        // starts at speed 30
        car1.Acclerate(50);

        Person p = new Person("Mahin", 24);
        p.Introduce();

    }
}
