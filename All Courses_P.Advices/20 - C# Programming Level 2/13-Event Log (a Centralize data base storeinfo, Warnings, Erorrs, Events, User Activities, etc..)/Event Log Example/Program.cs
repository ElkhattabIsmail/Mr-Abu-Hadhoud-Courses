using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Property , AllowMultiple = false)] // AttributeUsage { Classes,Fields, Property,Constructor..}
public class ExeptionErrorAttribute : Attribute
{
    public bool  GetException { get; }
    public string ErrorMessage { get; set; }

    public ExeptionErrorAttribute(bool GetException)
    {
        GetException = this.GetException;
    }
}
public class ClsLogException
{
    [ExeptionError(true, ErrorMessage = "An Exception Error Occur!")]
    public bool IsError { get; set; }
    public ClsLogException(string ErrorMsg , string SourceName, EventLogEntryType Type)
    {
        if (!EventLog.SourceExists(SourceName))
        {
            EventLog.CreateEventSource(SourceName, "Application");
            IsError = false;
        }
        EventLog.WriteEntry(SourceName, ErrorMsg, Type);
    }

}
class Program
{
    static void Main()
    {
        // Specify the source name for the event log
        string sourceName = "Ismail";


        // Create the event source if it does not exist
        if (!EventLog.SourceExists(sourceName))
        {
            EventLog.CreateEventSource(sourceName, "Application");
            Console.WriteLine("Event source created.");
        }


        // Log an information event
        EventLog.WriteEntry(sourceName, "This is My information :-).", EventLogEntryType.Information);
        
        // Log a Warning event
        EventLog.WriteEntry(sourceName, "This My Warning :-)", EventLogEntryType.Warning);

        // Log an Error event
        EventLog.WriteEntry(sourceName, "This My Error :-)", EventLogEntryType.Error);


        Console.WriteLine("Event written to the log.");
        Console.ReadKey();

    }
    static bool ValidateErrors(ClsLogException LogException, PropertyInfo property)
    {
        if (Attribute.IsDefined(property, typeof(ExeptionErrorAttribute)))
        {
            var ExceptionStatus = (ExeptionErrorAttribute)Attribute.GetCustomAttribute(property, typeof(ExeptionErrorAttribute));
            bool value = (bool)property.GetValue(LogException);

            // Perform validation
            if (!value)
            {
                Console.WriteLine($"Validation failed '{property.Name}': {ExceptionStatus.ErrorMessage}");
                return false;
            }
        }
        return true;
    }
}