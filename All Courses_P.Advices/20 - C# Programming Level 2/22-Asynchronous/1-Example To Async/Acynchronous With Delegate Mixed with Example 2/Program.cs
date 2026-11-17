using System;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting tasks...");

        Task task1 = DownloadAndPrintAsync("https://www.cnn.com" , PrintWebPageContentOnFile);
        Console.WriteLine("Task 1 started...");

        // Start the second task to download and print content length from Amazon
        Task task2 = DownloadAndPrintAsync("https://www.amazon.com", PrintWebPageContentOnFile);
        Console.WriteLine("Task 2 started...");

        // Start the third task to download and print content length from ProgrammingAdvices
        Task task3 = DownloadAndPrintAsync("https://www.ProgrammingAdvices.com", PrintWebPageContentOnFile);
        Console.WriteLine("Task 3 started...\n");

        // Wait for all tasks to complete
        await Task.WhenAll(task1, task2, task3);


        // Print a message indicating that all tasks have finished execution
        Console.WriteLine("\nDone, all tasks finished execution.");
        Console.ReadKey();
    }

    static void PrintWebPageContentOnFile(string URL,string Content )
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("WebCont.txt"))
            {
                sw.WriteLine($"WebPage URL : {URL}");
                sw.WriteLine($"Total WebPage Chars : {Content.Length} characters downloaded");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static async Task DownloadAndPrintAsync(string url , Action<string, string> CallBack)
    {

        string content;

        using (WebClient client = new WebClient())
        {
            await Task.Delay(100);

            content = await client.DownloadStringTaskAsync(url);

            CallBack?.Invoke(url, content);
        }

        // Print the URL and the length of the downloaded content
        Console.WriteLine($"{url}: {content.Length} characters downloaded");
    }

}
