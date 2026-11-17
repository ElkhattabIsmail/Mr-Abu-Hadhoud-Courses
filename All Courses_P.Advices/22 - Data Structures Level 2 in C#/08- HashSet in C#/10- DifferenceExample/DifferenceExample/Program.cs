using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 ,7};
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };


        // Removing elements of set2 from set1
        // Removing Intersections from set 1 and set 2;

        set1.ExceptWith(set2);   // all items from set 1 does not exist in set 2.


        Console.WriteLine("Difference of sets (set1 - set2):");
        foreach (int item in set1)
        {
            Console.WriteLine(item); // 1, 2, 7
        }


        set2.ExceptWith(set1);   // all items from set 2 does not exist in set 1.


        Console.WriteLine("Difference of sets (set2 - set1):");
        foreach (int item in set2)
        {
            Console.WriteLine(item); // 4, 5
        }
        Console.ReadKey();

    }
}