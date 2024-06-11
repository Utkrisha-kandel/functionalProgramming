using System;

public class Program
{
    public static int AddOne(int x)
    {
        return x + 1;
    }

    public static int MultiplyByThree(int x)
    {
        return x * 3;
    }

    // Function composition
    public static Func<int, int> Compose(Func<int, int> f, Func<int, int> g)
    {
        return x => f(g(x));
    }

    public static void Main()
    {
        // Composed function
        var addOneThenMultiplyByThree = Compose(MultiplyByThree, AddOne);

        // Test case
        Console.WriteLine(addOneThenMultiplyByThree(4));  // Output: 15 ((4 + 1) * 3)
    }
}
