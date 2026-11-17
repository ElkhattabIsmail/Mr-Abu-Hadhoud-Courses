using System;

class Program
{
    // A delegate that represents an operation
    delegate int Operation(int x, int y);

    // A function that takes a delegate with parameters and invokes it
    static void ExecuteOperation(int x,int y, Operation operation)
    {
        int result = operation(x, y); // Invoke the provided delegate
        Console.WriteLine("Result: " + result);
    }
    
    // now we use fun and lambda Expression 

    static void ExecuteOperation(int x, int y, Func<int, int, int> Operation)
    {
        int result = Operation(x, y); // Invoke the provided delegate
        Console.WriteLine("Result: " + result);
    }
    static int Power(int x, int y)
    {
        return Power(x, y);
    }
    static void Main()
    {
      

        Console.WriteLine("\n\nUsing Func Delegate and lambda expression");

        // now use the way 2 instead of previous way
        // Use a lambda expression for addition
        Func<int, int, int> Add = (x, y) => x + y; // => Lambda Operator
        Func<int, int, int> Sub= (x, y) => x - y;
        Func<int, int, int> Mul = (x, y) => x * y;
        Func<int, int, int> Div = (x, y) => x / y;
        Func<int, int, int> Mood = (x, y) => x % y;

        Operation PowerOp = Power;
        ExecuteOperation(10, 2, PowerOp);

        ExecuteOperation(10, 20, Add); // Pass the lambda expression as an argument
        ExecuteOperation(10, 20, Sub);
        ExecuteOperation(20, 10, Div);
        ExecuteOperation(10, 10, Mul);
        ExecuteOperation(21, 2, Mood);


        Console.ReadLine();

    }
}
