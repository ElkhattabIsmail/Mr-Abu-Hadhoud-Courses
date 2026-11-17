using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Define the number of iterations
        int numberOfIterations = 10;

        //Use Parallel.For to execute the loop in parallel
        // using 10 treads to run this function.
        Parallel.For(0, numberOfIterations, i =>
        {
            // Function Or Body.
            Console.WriteLine($"Executing iteration {i} on thread {Task.CurrentId}");
            // Simulate some work
            Task.Delay(1000).Wait();
        });
        //Thread[] threads = new Thread[numberOfIterations];

        //for (int i = 0; i < numberOfIterations; i++)
        //{
        //    int iteration = i; // Capture the loop variable to avoid closure issues
        //    threads[i] = new Thread(() => Processing(iteration));
        //    threads[i].Start();
        //}
        //foreach (Thread thread in threads)
        //{
        //    thread.Join();
        //}
        Console.WriteLine("All iterations completed.");
        Console.ReadKey();

    }
    static void Processing(int i)
    {
        Console.WriteLine($"Executing iteration {i} on thread {Thread.CurrentThread.ManagedThreadId}");
        // Simulate some work
        Thread.Sleep(1000);
    }
}


