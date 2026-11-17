using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Previous_Examples_in_One_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 2, 3, 4, 4, 5 };

            // Initializing a HashSet with the array
            HashSet<int> uniqueNumbers = new HashSet<int>(array);// rmv 4


            uniqueNumbers.Remove(5); // rmv 5

            // Display
            foreach (int Num in uniqueNumbers)
            {
                Console.WriteLine(Num);
            }

            // Using LINQ to filter out even numbers
            var evenNumbers = uniqueNumbers.Where(n => n % 2 == 0);

            // Using LINQ to find numbers < than 3
            var numbersGreaterThan3 = uniqueNumbers.Where(n => n < 3);


            HashSet<string> names = new HashSet<string>
                        { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona" };
            // Using LINQ to filter names that start with 'C'
            var namesStartingWithC = names.Where(name => name.StartsWith("C"));


            int[] arr1 = { 1, 2, 3, 4, 1, 3 };
            int[] arr2 = { 0, 0, 6, 3, 4, 12, 3, 13 };
            HashSet<int> uniqueNumbers1 = new HashSet<int>(arr1);
            HashSet<int> uniqueNumbers2 = new HashSet<int>(arr2);
            uniqueNumbers1.UnionWith(uniqueNumbers2);
            // Get all sets with no Duplication
            //return uniqueNumbers1.ToArray();


            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
            //Combine the elements of two sets using the UnionWith method in HashSet<T> (Remove InterSection);
            // Union of set1 and set2
            set1.UnionWith(set2);


            // Intersection of set1 and set2  -> from set1 get same from set 2.
            set1.IntersectWith(set2);

            // Removing elements of set2 from set1
            // Removing Intersections from set 1 and set 2;
            set1.ExceptWith(set2);   // Remove all items from set 1 that not exist in set 2.


            //  removing 3 from set 1 and removing from set 2 , last thing merging sets

            // ExcepWith Hold Number 3 but SymmetricExceptWith is not.
            // Retaining elements unique to each set using SymmetricExceptWith.
            // Symmetric difference between set1 and set2
            set1.SymmetricExceptWith(set2);


            //this will remove all elements
            uniqueNumbers.Clear();
        }
    }
}
