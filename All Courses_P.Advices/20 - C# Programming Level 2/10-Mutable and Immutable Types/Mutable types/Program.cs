using System;
using System.Text;
class Program
{
    static  void Main()
    {
        string str1 = "Hello";
        str1 += " World";  // This does NOT modify str1, but creates a NEW string

        Console.WriteLine(str1);  // Output: Hello World

        StringBuilder sb = new StringBuilder("Hello");
        sb.Append(" World");  // Modifies the same object in memory

        Console.WriteLine(sb.ToString());  // Output: Hello World
    }
}