using System;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Threading;
class Program
{
    // the simple way

    static void Main()
    {
        //Note that your program is the main thread.

            //new Thread(() => Method1("Thread1")): Creates a new thread and assigns it a lambda expression to execute
            //Method1("Thread1").
            //t.Start();: Starts the execution of the thread.
        // Create a new thread and start it
        Thread t = new Thread( () => Method1("Thread1"));  // the start Calls the () and the () Calls the parameterized function.
        t.Start();

        Thread t2 = new Thread( () => Method2("Thread" , 2));
        t2.Start();

           //t.Join();: The main thread waits for t to finish execution before proceeding.
          //t2.Join();: Similarly, the main thread waits for t2 to complete.
           t.Join();
        t2.Join();

        // Main thread continues its execution
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("\tMain: " + i);
            Thread.Sleep(500); // Sleep for 0.5 second
        }
        Console.ReadKey();
    }


    static void Method1(string ThreadName)
    {
        

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\t{ThreadName} Method1: " + i);
            Thread.Sleep(500);
        }
    }

    static void Method2(string ThreadName , int ThreadNumber)
    {


        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\t{ThreadName} Method{ThreadNumber}: " + i);
            Thread.Sleep(500);
        }
    }



}
