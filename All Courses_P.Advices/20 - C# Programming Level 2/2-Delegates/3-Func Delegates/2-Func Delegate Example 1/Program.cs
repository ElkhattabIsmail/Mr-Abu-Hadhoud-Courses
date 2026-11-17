using System;

class Program
{

    // Define a Func delegate for squaring a number
    static Func<int, int> square = SquareMethod;
    // Func <Parameters Until 16 Parameter ,  Last One = Type Result Or Return Type.
    // Func is a shotcut to Delegate
    static Func<int, int> DoubleValue = DoubleNumberMethod;
    // Define a method that squares a number
    static int SquareMethod(int x)
    {
        return x * x;
    }
    static int DoubleNumberMethod(int x)
    {
        return x * 2;
    }
    static void Main()
    {
        // Use the square Func to square the number 5
        int result = square(5);
        int result2 = square(10);

        // Print the result
        Console.WriteLine("The square of 5 is: " + result);
        Console.WriteLine("The square of 10 is: " + result2);
        Console.WriteLine($"The Double of {result} is: " + DoubleValue(result));
        Console.WriteLine($"The Double of {result2} is: " + DoubleValue(result2));


        Console.ReadKey();

    }
}
