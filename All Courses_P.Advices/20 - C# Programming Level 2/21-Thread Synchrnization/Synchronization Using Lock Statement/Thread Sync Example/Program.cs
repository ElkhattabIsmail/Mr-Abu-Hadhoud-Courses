using System;
using System.Threading;

class Program
{
    static int sharedCounter = 0;
    static object lockObject = new object();


    static void Main()
    {
        // Create two threads that increment a shared counter
        Thread t1 = new Thread(() => IncrementCounter("T1"));
        Thread t2 = new Thread(() => IncrementCounter("T2"));


        t1.Start();
        t2.Start();


        // Wait for both threads to complete
        t1.Join();
        t2.Join();


        Console.WriteLine("Final Counter Value: " + sharedCounter);
        Console.ReadKey();
    }


    static void IncrementCounter(string ThreadName)
    {
        for (int i = 0; i < 7; i++)
        {
            // Use lock to synchronize access to the shared counter
            lock (lockObject) // lock function appoint the LockObject as a guardien of his body
            {
                sharedCounter++; // just one thread at a time can access and Modify this variable.
                Console.WriteLine($"Variable Modified By {ThreadName}");
                Console.WriteLine($"Value of the Varialble = {sharedCounter}");
                Thread.Sleep(2000);
            }
            Console.WriteLine($"Value of the Counter Out of the lock body = {sharedCounter}");
            // outside lock body accessible to all threads.
        }
    }
}