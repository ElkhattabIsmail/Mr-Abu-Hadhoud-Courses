using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Array initialization
        int[] numbersArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Converting the array to a list
        List<int> numbersList = new List<int>(numbersArray);

        // Displaying the list elements
        Console.WriteLine("List elements: " + string.Join(", ", numbersList));

        Stack<int> sk = new Stack<int>();
        sk.Push(3);
        sk.Push(2);
        sk.Push(1);

        List<int> stacknumbersToList = new List<int>(sk);
        Console.WriteLine("List elements: " + string.Join(", ", stacknumbersToList));

        Queue<int> Q = new Queue<int>();
        Q.Enqueue(1);
        Q.Enqueue(2);
        Q.Enqueue(3);

        List<int> QueeuenumbersToList = new List<int>(Q);
        Console.WriteLine("List elements: " + string.Join(", ", QueeuenumbersToList));

      

        Console.ReadKey();
    }
}
