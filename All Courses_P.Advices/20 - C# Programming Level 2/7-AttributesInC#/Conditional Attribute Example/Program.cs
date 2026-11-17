//#define DEBUG

using System;
using System.Diagnostics;

public class MyClass
{
    [Conditional("DEBUG")]
    public void DebugMethod() // // This will be only executed in DEBUG Mode
    {
        Console.WriteLine("Debug method executed.");  // Not Executed IN Release Mode
    }

    public void NormalMethod()
    {
        Console.WriteLine("Normal method executed.");// This will always be executed
    }
}

class Program
{
    static void Main()
    {
        MyClass myClass = new MyClass();

        // Call the methods
        myClass.DebugMethod();  
        myClass.NormalMethod(); 

        Console.ReadLine();
    }
}
