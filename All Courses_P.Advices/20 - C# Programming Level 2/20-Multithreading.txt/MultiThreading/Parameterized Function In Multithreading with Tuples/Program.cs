using System;
using System.Threading;

class Program
{
    // the hard way
    static void Main()
    {
        // Creating a new thread using ParameterizedThreadStart
        Thread t = new Thread(new ParameterizedThreadStart(Method1));
        t.Start("Thread1"); // Passing a string as a parameter

        // Creating another thread and passing multiple parameters using Tuple
        Thread t2 = new Thread(new ParameterizedThreadStart(Method2));
        t2.Start(Tuple.Create("Thread", 2)); // Passing a tuple

        // Waiting for both threads to complete
        t.Join();
        t2.Join();

        // Main thread execution
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("\tMain: " + i);
            Thread.Sleep(500); // Sleep for 0.5 seconds
        }

        Console.ReadKey();
    }

    // Method1 using object parameter and casting it to string
    static void Method1(object threadName)
    {
        string name = (string)threadName; // Type casting
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\t{name} Method1: " + i);
            Thread.Sleep(500);
        }
    }

    // Method2 using Tuple to pass multiple parameters
    static void Method2(object threadData)
    {
        var data = (Tuple<string, int>)threadData; // Type casting
        string name = data.Item1;
        int number = data.Item2;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\t{name} Method{number}: " + i);
            Thread.Sleep(500);
        }
    }
}
