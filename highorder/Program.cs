using System;

public class Program
{
    // Higher-order function example
    public static Func<int, int> Multiplier(int factor)
    {
        return x => x * factor;
    }

    public static void Main()
    {
        // Creating new functions using a higher-order function
        var doubleFunction = Multiplier(2);
        var tripleFunction = Multiplier(3);

        // Test cases
        Console.WriteLine(doubleFunction(5));  // Output: 10
        Console.WriteLine(tripleFunction(5));  // Output: 15
    }
}
