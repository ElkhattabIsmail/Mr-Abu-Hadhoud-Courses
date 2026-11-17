using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        //  removing 3 from set 1 and removing from set 2 , last thing merging sets

        // ExcepWith Hold Number 3 but SymmetricExceptWith is not.
        // Retaining elements unique to each set using SymmetricExceptWith.
        // Symmetric difference between set1 and set2
        set1.SymmetricExceptWith(set2);

        // In Brief is Remove Duplicates from Sets.

        Console.WriteLine("Symmetric difference of sets:");
        foreach (int item in set1)
        {
            Console.WriteLine(item);  // output 1,2,4,5
        }
        Console.ReadKey();
    }
}