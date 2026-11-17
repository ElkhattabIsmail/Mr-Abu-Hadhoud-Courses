using System;


class Program
{
    static void Main()
    {
        // Reflection using Type Class
        Type myType = typeof(string); // Type of That Lib e.g string Library

        Console.WriteLine("Type Information:");
        Console.WriteLine($"Name: {myType.Name}");
        Console.WriteLine($"Full Name: {myType.FullName}");
        Console.WriteLine($"Is Class: {myType.IsClass}");
        Console.WriteLine($"Module: {myType.Module}");
        Console.WriteLine($"Namespace: {myType.Namespace}");
        Console.WriteLine($"Attributes Using: {myType.Attributes}");
        Console.WriteLine($"Methods: {myType.GetMethods()}");



        Console.ReadLine();
    }
}