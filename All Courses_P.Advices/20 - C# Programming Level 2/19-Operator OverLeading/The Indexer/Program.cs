using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System;


class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Change the behavior of + sign
    // Overloading the + operator for point addition
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }
    // Change the behavior of - sign
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    // Overloading the == operator for fraction equality
    public static bool operator ==(Point p1, Point p2)
    {
        return (p1.X == p2.X) && (p1.Y == p2.Y);
    }
    // If you are Implemented the == operator , you must Implement the != also , or you get an error
    // Overloading the != operator for fraction equality
    public static bool operator !=(Point p1, Point p2)
    {
        return (p1.X != p2.X) || (p1.Y != p2.Y);
    }

    // By defaut all object in c# has the ToString() function thats why we override that function
    // Overriding ToString for better readability
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
class SampleCollection
{

    private Point[] pointsData = new Point[5]; // Internal array

    // Indexer property
    public Point this[int index]
    {
        get { return pointsData[index]; }  // Getter
        set { pointsData[index] = value; } // Setter
    }
}

class Program
{
    static void Main()
    {
     

        Console.ReadKey();
        //The indexing operator [] can only be overloaded using an indexer property.
        //It does not work for primitive types.

        SampleCollection collection = new SampleCollection();

        // Using the indexer like an array
        collection[0] = new Point (1,2);
        collection[1] = new Point(4, 5);

        Console.WriteLine(collection[0].ToString()); // (1,2)
        Console.WriteLine(collection[1].ToString()); // (4,5)

        Console.ReadKey();
    }
}
//🔹 How It Works
//The this[int index] defines an indexer property.
//It allows getter and setter access to the internal pointsData array.
//We can now use collection[0] like an array, even though collection is an object.
//🔹 Real-World Example: Dictionary Indexer
//Many built-in collections, like Dictionary<TKey, TValue>, use indexers:

//csharp
//Copier
//Modifier
//Dictionary<string, int> ages = new Dictionary<string, int>();

//ages["Alice"] = 25; // Using indexer
//ages["Bob"] = 30;

//Console.WriteLine(ages["Alice"]); // Output: 25