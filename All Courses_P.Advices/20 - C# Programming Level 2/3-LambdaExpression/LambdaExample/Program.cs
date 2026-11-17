
//delegation & lambda expression


using System;

class SimpleCalculator
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Square (^2)");
            Console.WriteLine("6. Cube (^3)");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an operation (1-7): ");

            switch (Console.ReadLine())
            {
                case "1": PerformCalculation((a, b) => a + b, "+"); break;
                case "2": PerformCalculation((a, b) => a - b, "-"); break;
                case "3": PerformCalculation((a, b) => a * b, "*"); break;
                case "4": PerformCalculation((a, b) => b == 0 ? double.NaN : a / b, "/"); break;
                case "5": PerformCalculation(a => a * a, "^2"); break;
                case "6": PerformCalculation(a => a * a * a, "^3"); break;
                case "7": return;
                default: Console.WriteLine("Invalid choice. Try again."); break;
            }
        }
    }

    // By using this way, this procedure allways be static.
    static void PerformCalculation(Func<double, double, double> operation, string symbol)
    {
        double num1 = GetNumber("Enter the first number: ");
        double num2 = GetNumber("Enter the second number: ");
        double result = operation(num1, num2);

        if (double.IsNaN(result))
            Console.WriteLine("Error: Division by zero is not allowed.");
        else
            Console.WriteLine($"Result: {num1} {symbol} {num2} = {result}");

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }


    // By using this way, this procedure allways be static.
    static void PerformCalculation(Func<double, double> operation, string symbol)
    {
        double num = GetNumber("Enter the number: ");
        double result = operation(num);
        Console.WriteLine($"Result: {num} {symbol} = {result}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static double GetNumber(string message)
    {
        Console.Write(message);
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
            Console.Write("Invalid input. " + message);
        return number;
    }
}