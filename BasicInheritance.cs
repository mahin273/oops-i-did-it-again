using System;

//Base Class
class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping");
    }
}

//Derived Class - inherits from Animal using the : symbol

class Dog : Animal
{
    public string Breed { get; set; }

    //'base(...)' is used to call the constructor of the base class (Animal) to initialize the inherited properties
    public Dog(string name,int age,string breed) : base(name, age)
    {
        Breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

class Cat : Animal
{
    public string Color { get; set; }
    public Cat(string name, int age, string color) : base(name, age)
    {
        Color = color;
    }
    public void Meow()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}


public static class AnimalDemo
{
    public static void Run()
    {
        Dog dog = new Dog("Buddy", 3, "Golden Retriever");
        dog.Eat();   // Inherited method
        dog.Bark();  // Dog's own method
        Cat cat = new Cat("Whiskers", 2, "Tabby");
        cat.Sleep(); // Inherited method
        cat.Meow();  // Cat's own method
    }
}