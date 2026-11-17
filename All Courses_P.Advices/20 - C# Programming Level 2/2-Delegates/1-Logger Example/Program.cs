using System;
using System.IO;

// The Main Class (Orcastrater)
// Pass The Function as a parameter
public class Logger
{
    // Define a delegate for log actions
    public delegate void LogAction(string message);

    // The log action that will be invoked
    private LogAction _logAction; // Any Function with This Signiture can link it with that delegate

    public Logger(LogAction action) // in constructor we take the function we want to call it and pass it to the delegate
    {
        _logAction = action;
        // Or _logAction += action; // For Subscribe the delegate
    }
    public void Log(string message)
    {
        _logAction(message);  // call the Function 
        // Or _logAction?.Invoke (message);
    }
}

public class Program
{
    // Method to log to the screen
    public static void LogToScreen(string message)
    {
        Console.WriteLine(message);
    }
    public static void LogToFile(string message)
    {
        string fileName = "log.txt";
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine(message);
        }
    }
    public static void LogToDatabase(string message)
    {
        //write the code to log the message in the database .

       Console.Write(message);


    }
    public static void Main(string[] args)
    {
        Logger screenLogger = new Logger(LogToScreen);
        Logger fileLogger = new Logger(LogToFile);
        Logger DBLogger = new Logger(LogToDatabase);

        screenLogger.Log("This message will be displayed on the screen.");
        fileLogger.Log("This message will be displayed to The file.");
        DBLogger.Log("This message will be logged to database.");

        // You can easily switch between logging to the screen or a file by changing the Logger instance.

        Console.ReadLine();

    }
}
