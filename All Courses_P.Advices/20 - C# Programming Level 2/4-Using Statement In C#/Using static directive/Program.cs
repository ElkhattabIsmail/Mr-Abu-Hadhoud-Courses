using System;  // System Not a class is group of classes

// using static directive
// using With Class Not with a Namespace;
using static System.Math;
using static System.Console;


namespace Program
{

    class Program1
    {
        public static void Main(string[] args)
        {
            // Before
            //double n = Math.Sqrt(9);
            // After Using static System.Math;
            double n = Sqrt(9);
            WriteLine("Square root of 9 is " + n);
        }
    }
}