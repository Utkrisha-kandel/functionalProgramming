using System;

public class Program
{
    // Function that takes another function as an argument
    public static int ApplyFunction(Func<int, int> func, int value)
    {
        return func(value);
    }

    // Example functions
    public static int Increment(int x)
    {
        return x + 1;
    }

    public static int Square(int x)
    {
        return x * x;
    }

    public static void Main()
    {
        // Test cases
        Console.WriteLine(ApplyFunction(Increment, 3));  // Output: 4
        Console.WriteLine(ApplyFunction(Square, 4));     // Output: 16
    }
}
