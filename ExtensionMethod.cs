using System;
using System.Linq;

//Must be in a static Class
static class StringExtensions
{

    public static bool IsNullOrEmpty(this string? input)
    {
        return string.IsNullOrEmpty(input);
    }

    public static string Truncate(this string input,int maxLength)
    {
        if(input.Length<=maxLength) return input;
        return input[..maxLength] + "...";
    }
    public static string ToTitleCase(this string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        return string.Join(" ",
            input.Split(' ')
                 .Select(w => char.ToUpper(w[0]) + w[1..].ToLower()));
    }
}

public static class StringExtensionsDemo
{
    public static void Run()
    {
        // Now you can call these as if they were string methods
        string title = "hello world from bangladesh";
        Console.WriteLine(title.ToTitleCase());            // Hello World From Bangladesh
        Console.WriteLine(title.Truncate(10));             // hello worl...

        string? name = null;
        Console.WriteLine(name.IsNullOrEmpty());           // Tru
    }
}