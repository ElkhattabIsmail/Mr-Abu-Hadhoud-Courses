using System;

class Program
{
    static void Main()
    {
        // Declare and initialize Action delegates

        Action parameterlessAction = () =>   // Point to Anonymous Parameterless Procudure
        {
            Console.WriteLine("This is a parameterless action.");
        };

        Action<int> actionWithIntParameter = (x) => // Point to Anonymous Procudure with 1 argument
        {
            Console.WriteLine($"Action with int parameter: {x}");
        };

        Action<string, int> actionWithMultipleParameters = (str, num) => // Point to Anonymous Procudure with 2 argument
        {
            Console.WriteLine($"Action with string and int parameters: {str}, {num}");
        };

        // Invoking the actions

        parameterlessAction();
        actionWithIntParameter(42);
        actionWithMultipleParameters("Hello, World!", 100);

        Console.ReadKey();

    }
}
