using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // List initialization
        List<int> numbers = new List<int> { 44, 22, 55, 666, 9, -6, 345, 11, 3, 3 };

        // Default Sorting (Ascending)
        numbers.Sort();
        Console.WriteLine("Sorted in Ascending Order: " + string.Join(", ", numbers));

        // Sorting in Descending Order
        numbers.Reverse();
        Console.WriteLine("Sorted in Descending Order: " + string.Join(", ", numbers));

        // Sorting Using LINQ
        Console.WriteLine("Sorted Ascending with LINQ: " + string.Join(", ", numbers.OrderBy(n => n)));
        Console.WriteLine("Sorted Descending with LINQ: " + string.Join(", ", numbers.OrderByDescending(n => n)));

       
        Console.ReadKey();
    }
}

//This lesson showed various methods to sort a List<int> in C#,
//ranging from the straightforward Sort method to more complex custom sorting logic.
//Understanding these sorting techniques is crucial for data manipulation and presentation in software development.
