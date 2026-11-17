using System;

namespace Rectangle_Area___Perimeter_Example
{
    internal class Program
    {
        public delegate void Rectangle (decimal W, decimal H);
        static void Main(string[] args)
        {
            Rectangle_Area_Perimeter rectangle = new Rectangle_Area_Perimeter();

            Rectangle Rec;
            Rec = rectangle.RecArea;
            Rec += rectangle.RecPerimeter;
            Rec(10, 10);


            Rec -= rectangle.RecPerimeter;
            Console.WriteLine("After RecPerimeter Unsubscribe :");
            
            Rec(10, 10);

            Console.ReadKey(); 
        }
        class Rectangle_Area_Perimeter
        {
            public void RecArea(decimal W, decimal H)
            {
                Console.WriteLine(W * H);
            }
            public void RecPerimeter(decimal W, decimal H)
            {
                Console.WriteLine((W + H) * 2);
            }
        }

    }
}
