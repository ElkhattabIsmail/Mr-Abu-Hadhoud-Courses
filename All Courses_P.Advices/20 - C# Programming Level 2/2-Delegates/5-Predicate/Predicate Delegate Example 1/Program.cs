using System;

class Program
{

    // Define a Func delegate for squaring a number
    static Predicate <int> IsEvenPredicate = IsEven; // Predicate Point to IsEven Function

    // Define a method that squares a number
    static bool IsEven(int x)
    {
        return (x % 2 == 0);
    }

    static void Main()
    {
        // Use the IsEven Func to square the number 5
        bool result = IsEvenPredicate(6);

        // Print the result
        Console.WriteLine("Is Number 6  Even ?  " + result);
        Console.ReadKey();

    }
}
