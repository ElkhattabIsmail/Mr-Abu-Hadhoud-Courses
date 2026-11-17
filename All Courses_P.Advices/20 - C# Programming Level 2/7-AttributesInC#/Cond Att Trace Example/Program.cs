//#define ExucuteLogTrace
#define Exucute_LogTrace2

// if the attributes not defines the function Doesn't work

using System;
using System.Diagnostics;

public class TraceExample
{



    [Conditional("ExucuteLogTrace")]
    public static void LogTrace(string message)
    {
        Console.WriteLine($"[TRACE] {message}");
    }

    [Conditional("Exucute_LogTrace2")]
    public static void LogTrace2(string message)
    {
        Console.WriteLine($"[TRACE2] {message}");
    }

    public static void Main()
    {
        LogTrace("This trace message will only be included if ExucuteLogTrace symbol is defined.");
        LogTrace2("This trace2 message will only be included if ExucuteLogTrace2 symbol is defined.");

        Console.WriteLine("Rest of the program.");

        Console.ReadLine();
    }



}
