using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static T[] AllIntersectionsBetweenTwoArrays<T>(T[] arr1, T[] arr2)
    {
        if (arr1 == null || arr2 == null)
            throw new ArgumentNullException("Input arrays cannot be null.");

        HashSet<T> uniqueNumbers1 = new HashSet<T>(arr1);
        HashSet<T> uniqueNumbers2 = new HashSet<T>(arr2);

        uniqueNumbers1.IntersectWith(uniqueNumbers2);
        // Get set with no Duplication
        return uniqueNumbers1.ToArray();
    }

    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 1, 3 };
        int[] arr2 = { 0, 0, 6, 3, 4, 12, 3, 13 };

        int[] resultArr = AllIntersectionsBetweenTwoArrays(arr1, arr2);

        Console.WriteLine("Intersection of the two arrays:");
        foreach (int elem in resultArr)
        {
            Console.WriteLine(elem);
        }

        //To compute the intersection or Union of two sets without modifying set1 or set2,
        // you can use the Intersect method and Union method(via LINQ) instead of IntersectWith and UnionWith.

        //HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        //HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        //// Get the intersection without modifying set1
        //HashSet<int> set3 = new HashSet<int>(set1.Intersect(set2));  // gives 3

        //HashSet<int> set4 = new HashSet<int>(set1.Union(set2));

        //Console.WriteLine("Intersection of sets:");
        //foreach (int item in set2)
        //{
        //    Console.WriteLine(item);
        //}
    }
}
