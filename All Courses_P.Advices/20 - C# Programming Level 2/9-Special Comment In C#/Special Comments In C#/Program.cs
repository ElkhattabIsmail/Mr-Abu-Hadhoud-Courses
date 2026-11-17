using System;
// xml tags
/// <summary>
/// This class represents a simple calculator.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two numbers and returns the result.
    /// </summary>
    /// <param name="a">The first number to be added.</param>
    /// <param name="b">The second number to be added.</param>
    /// <returns>The sum of the two numbers.</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts the second number from the first number and returns the result.
    /// </summary>
    /// <param name="a">The number from which to subtract.</param>
    /// <param name="b">The number to subtract.</param>
    /// <returns>The result of subtracting the second number from the first number.</returns>
    
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    /// <summary>
    /// Multiple the Two numbers and returns the result.
    /// </summary>
    /// <param name="a">Number 1 .</param>
    /// <param name="b">Number 2 .</param>
    /// <returns>The result of Multiple the Two numbers</returns>
    public int Multiple(int a, int b)
    {
        return a * b;
    }
}

class Program
{

    static void Main()
    {
        // Create an instance of the Calculator class
        Calculator myCalculator = new Calculator();

        // Example usage of the Add method
        int sum = myCalculator.Add(5, 3);


        Console.WriteLine("Sum: " + sum);

        int Mul = myCalculator.Multiple (3,5);


        Console.WriteLine("Mul: " + Mul);

        // Example usage of the Subtract method
        int difference = myCalculator.Subtract(2, 3);
        Console.WriteLine("Difference: " + difference);

        Console.ReadKey();  

    }
}
