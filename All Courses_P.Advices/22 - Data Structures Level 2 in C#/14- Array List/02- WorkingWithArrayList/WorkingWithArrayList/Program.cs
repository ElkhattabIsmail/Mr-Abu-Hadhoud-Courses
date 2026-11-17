using System;
using System.Collections;
using System.Xml.Linq;


class Program
{
    static void Main(string[] args)
    {
        /*ArrayList is a dynamic array that can hold elements of any data type.
         It's part of the System.Collections namespace.
         Unlike arrays, ArrayList can grow dynamically as elements are added,
         but it does not automatically decrease its capacity when elements are removed.*/

        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add(20);
        list.Add(30);


        Console.WriteLine("Elements in ArrayList:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("ArrayList Capacity Before Deleting:" + list.Capacity);
        
        list.Remove(20); // Removing an element

        Console.WriteLine("ArrayList Capacity after Deleting:" + list.Capacity);

        list.TrimToSize();

        Console.WriteLine("ArrayList Capacity after Using 'TrimToSize()':" + list.Capacity);

        Console.WriteLine("\nAfter removing an element:");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}