using System;

class Program
{


    // Define a delegate type for squaring a number
    delegate int SquareDelegate(int x); // take a function with same signiture ! and Return Integer type

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
        // Create an instance of the SquareDelegate and associate it with the SquareMethod
        SquareDelegate square = new SquareDelegate(SquareMethod);

        // Use the square delegate to square the number 5
        int result = square(5);

        // Print the result
        Console.WriteLine("The square of 5 is: " + result);


        SquareDelegate DoubleNum = new SquareDelegate(DoubleNumberMethod);
        // Print the result
        int Num = 12;
        Console.WriteLine($"The Double of {Num} is: " + DoubleNum(Num));
        Console.ReadKey();

    }
}
