using System;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int X, int Y)
    {
        this.X = X;
        this.Y = Y;
    }


    // Overloading the + operator for point addition
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    // Overloading the - operator for point subtraction
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    // Overloading the * operator for point multiplication
    public static Point operator *(Point p1, Point p2)
    {
        return new Point(p1.X * p2.X, p1.Y * p2.Y);
    }

    // Overloading the / operator for point division
    public static Point operator /(Point p1, Point p2)
    {
        try
        {
            int X = p1.X / p2.X;
            int Y = p1.Y / p2.Y;
            return new Point(X, Y);
        }

        catch (Exception ex)
        {
            throw ex.GetBaseException();
        }

    }


    public static bool operator <(Point p1, Point p2)
    {
        return ( p1.X + p1.Y ) < ( p2.X + p2.Y );
    }

    public static bool operator >(Point p1, Point p2)
    {
        return  (p1.X + p1.Y) > (p2.X + p2.Y);
    }

    public static bool operator <=(Point p1, Point p2)
    {
        return (p1.X + p1.Y) <= (p2.X + p2.Y);
    }

    public static bool operator >=(Point p1, Point p2)
    {
        return (p1.X + p1.Y) >= (p2.X + p2.Y);
    }

    // Overloading the == operator for fraction equality
    public static bool operator ==(Point p1, Point p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }
    // Overloading the != operator for fraction equality
    public static bool operator !=(Point p1, Point p2)
    {
        return p1.X != p2.X && p1.Y != p2.Y;
    }


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

};

class Program
{

    static void Main()
    {

        Point point1 = new Point(1, 2);
        Point point2 = new Point(3, 4);

        // Using the overloaded + operator for point addition
        Point point3 = point1 + point2;

        // Using the overloaded - operator for point subtraction
        Point point4 = point1 - point2;

        // Using the overloaded * operator for point multiplication
        Point point5 = point1 * point2;

        // Using the overloaded / operator for point division
        Point point6 = point1 / point2;

        Console.WriteLine($"Point1 : {point1.ToString()}");
        Console.WriteLine($"Point2 : {point2.ToString()}");
        Console.WriteLine($"Point3 is the result of point1 + point2: {point3.ToString()}");
        Console.WriteLine($"Point4 is the result of point1 - point2: {point4.ToString()}");
        Console.WriteLine($"Point3 is the result of point1 * point2: {point5.ToString()}");
        Console.WriteLine($"Point4 is the result of point1 / point2: {point6.ToString()}");

        Console.WriteLine("\n----------****---------\n");

        // Using the overloaded == operator for point equality
        if (point1 == point2)
            Console.WriteLine("Using == : Yes, Point1 = Point2");
        else
            Console.WriteLine("Using == : No, Point1 does not equal Point2");

        // Using the overloaded != operator for point inequality
        if (point1 != point2)
            Console.WriteLine("Using != : Yes, Point1 does not equal Point2");
        else
            Console.WriteLine("Using != : No, Point1 = Point2");


        // Using the overloaded < operator for point compere less
        if (point1 < point2)
            Console.WriteLine("Using < : Yes, Point1 < Point2");
        else
            Console.WriteLine("Using < : No, Point1 does not less Point2");

        // Using the overloaded > operator for point compere more
        if (point1 > point2)
            Console.WriteLine("Using > : Yes, Point1 > Point2");
        else
            Console.WriteLine("Using > : No, Point1 does not more Point2");


        // Using the overloaded <= operator for point compere less or equal
        if (point1 <= point2)
            Console.WriteLine("Using <= : Yes, Point1 <= Point2");
        else
            Console.WriteLine("Using <= : No, Point1 does not less or equal to Point2");

        // Using the overloaded >= operator for point compere more or equal
        if (point1 >= point2)
            Console.WriteLine("Using >= : Yes, Point1 >= Point2");
        else
            Console.WriteLine("Using >= : No, Point1 does not more or equal to Point2");


        Console.ReadKey();
    }

}