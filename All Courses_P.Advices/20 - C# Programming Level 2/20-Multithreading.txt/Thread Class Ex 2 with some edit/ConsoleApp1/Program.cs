using System;
using System.Diagnostics;
using System.Net;
using System.Threading;

class Program
{

    static void Main()
    {

        Console.WriteLine("Starting threads...");
        Stopwatch stopwatch1 = Stopwatch.StartNew();

        Thread t1 = new Thread(() => DownloadAndPrint("https://www.cnn.com"));
        t1.Start();
        Console.WriteLine("Thread 1 started...");
        t1.Join();
        Console.WriteLine("\nThread 1 Finish Task.");
        Thread.Sleep(100);


        Thread t2 = new Thread(() => DownloadAndPrint("https://www.amazon.com"));
        t2.Start();
        Console.WriteLine("Thread 2 started...");
        t2.Join();
        Console.WriteLine("\nThread 2 Finish Task.");
        Thread.Sleep(100);

        Thread t3 = new Thread(() => DownloadAndPrint("https://www.ProgrammingAdvices.com"));
        t3.Start();
        Console.WriteLine("Thread 3 started...\n");
        t3.Join();
        Console.WriteLine("\nThread 3 Finish Task.");
        Thread.Sleep(100);

        Thread t4 = new Thread(() => DownloadAndPrint("https://github.com"));
        t4.Start();
        Console.WriteLine("Thread 4 started...\n");
        t4.Join();
        Console.WriteLine("\nThread 4 Finish Task.");
        Thread.Sleep(100);


        Console.WriteLine("\nDone all threads finished execution.");
        Console.WriteLine($"Time Consuming : {stopwatch1.ElapsedMilliseconds} ms");

        Console.ReadKey();

    }

    static void DownloadAndPrint(string url)
    {
        string content;

        using (WebClient client = new WebClient())
        {
            // Simulate some work by adding a delay
            Thread.Sleep(100);

            // Download the content of the web page
            content = client.DownloadString(url);
        }

        Console.WriteLine($"{url}: {content.Length} characters downloaded");
    }
}
