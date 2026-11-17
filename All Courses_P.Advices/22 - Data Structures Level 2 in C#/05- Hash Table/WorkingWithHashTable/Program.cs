using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Initialization
        Hashtable myHashtable = new Hashtable
        {
            { 1, "value1" },  // Unique Key
            { 2, "value2" },
            { 3, "value3" }
        };


        // Accessing an element
        Console.WriteLine($"Accessing key1: {myHashtable[1]}");

        // Modifying an element
        myHashtable[1] = "newValue1";

        // Removing an element
        myHashtable.Remove(2);

        // Iterating over elements
        Console.WriteLine("\nCurrent Hashtable contents:");
        foreach (DictionaryEntry entry in myHashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }


    }
}
