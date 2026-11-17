using System;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Parallel.Invoke(
            // Using Lambda Expression
            () => Console.WriteLine($"Action 1 on thread {Task.CurrentId}"),
            () => Console.WriteLine($"Action 2 on thread {Task.CurrentId}"),
            () => Console.WriteLine($"Action 3 on thread {Task.CurrentId}")
        );
        Console.WriteLine("All parallel functions are completed.");
        Console.ReadKey();

    }
}