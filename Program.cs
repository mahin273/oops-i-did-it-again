using System.Collections.Generic;
//==============Data Types and Variables==================



//==============String Operations====================
string firstName = "Mahin";
string lastName = "Khan";

string fullName = firstName + " " + lastName;

string greeting = $"Hello, {fullName}!";

string upper = fullName.ToUpper();
string lower = fullName.ToLower();

int length = fullName.Length;
bool has = fullName.Contains("ahin");
string trimmed = "               hello        ".Trim();
string[] parts = "a,b,c".Split(',');
string replaced = fullName.Replace("Mahin", "John");

System.Console.WriteLine(greeting);
System.Console.WriteLine(upper);
System.Console.WriteLine(lower);




//================Control Flow==================

int score = 85;

if (score >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (score >= 80)
{
    Console.WriteLine("B grade");
}
else
{
    Console.WriteLine("Below B grade");
}



//===================Loops==================

// for loop
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);   // prints 0, 1, 2, 3, 4
}

// while loop
int count = 0;
while (count < 3)
{
    Console.WriteLine(count);
    count++;
}

// foreach loop — used heavily with collections
string[] names = { "Alice", "Bob", "Charlie" };
foreach (string mahin in names)
{
    Console.WriteLine(mahin);
}



//===================Mathods or Functions==================

// Basic method
static int Add(int a, int b)
{
    return a + b;
}

//void method - no return value
static void PrintGreetings(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

//method with default parameter
static void Connect(string host, int port = 3001)
{
    Console.WriteLine($"Connecting to {host} on port {port}");
}

//method with multiple return values using tuple
static (string, int) GetUSser()
{
    return ("Mahin", 25);
}

int result = Add(5, 10);
PrintGreetings("Mahin");
Connect("localhost");
var (name, age) = GetUSser();


//===================Arrays and Collections==================

// Array - fixed size
int[] numbers = { 1, 2, 3, 4, 5 };
int[] zeros = new int[5];  // all elements initialized to 0
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers.Length);

// List - dynamic size==>List<T>
List<string> cities = new List<string>();
cities.Add("New York");
cities.Add("Dhaka");
cities.Add("Chittagong");
cities.Remove("Dhaka");
Console.WriteLine(cities.Count);
foreach (string city in cities)
{
    Console.WriteLine(city);
}

//Dictionary - key-value pairs==>Dictionary<TKey,TValue>

Dictionary<String, int> scores = new Dictionary<string, int>();
scores["Mahin"] = 85;
scores["Alice"] = 90;
scores["Bob"] = 78;
Console.WriteLine(scores["Alice"]);
Console.WriteLine(scores.ContainsKey("Bob"));
Console.WriteLine(scores.Count);
//Console.WriteLine(scores["Charlie"]);  // throws KeyNotFoundException
Console.WriteLine(scores.GetValueOrDefault("Charlie", -1));  // returns -1 instead of throwing


//===================Null and Null Safety==================

string? value = null;

if (value != null)
{
    Console.WriteLine(value.ToUpper());
}

string dispaly = name ?? "Unknown"; // if name is null, use "Unknown"
Console.WriteLine(dispaly);

int? vLength = value?.Length;
Console.WriteLine(vLength);






