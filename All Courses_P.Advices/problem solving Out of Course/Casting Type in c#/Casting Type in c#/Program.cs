using System;


namespace Casting_Type_in_c_
{
    internal class Program
    {

        enum WeekDays
        {
            Monday, // default = 0 , 1 , 2 , ...
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            int n = 1;
            string resul;
            // short hand if 
            resul = (n % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine("{0} is {1}", n, resul);



            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));

            Console.WriteLine("var++ = " + (number++));
            Console.WriteLine((number));


            Console.WriteLine("++var = " + (++number));
            Console.WriteLine((number));




            byte x = 3,//3=00000011
            y = 6,//6=00000110
            z = 0;//0=00000000

            z = (byte)(x & y);
            Console.WriteLine($"Bitwise & (x&y) {z}");//2

            z = (byte)(x | y);
            Console.WriteLine($"Bitwise & (x|y) {z}");//7

            z = (byte)(x ^ y);
            Console.WriteLine($"Bitwise & (x^y) {z}");//5

            z = (byte)(x << 1);
            Console.WriteLine($"Bitwise & (x<<=1) {z}");//6
            Console.WriteLine(x);

            z = (byte)(x << 2);
            Console.WriteLine($"Bitwise & (x<<=2) {z}");//12
            Console.WriteLine(x);

            z = (byte)(x >> 1);
            Console.WriteLine($"Bitwise & (x>>=1) {z}");//1
            Console.WriteLine(x);

            z = (byte)(x >> 2);
            Console.WriteLine($"Bitwise & (x>>=2) {z}");//0
            Console.WriteLine(x);


            Console.WriteLine("Pleace Enter Username : ");
            string Username = Console.ReadLine();
            Console.WriteLine("PLeace Enter Age : ");
            byte Age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"MY Username is {Username} ,Type Is : {Username.GetTypeCode()}");
            Console.WriteLine($"MY Username is {Age} ,Type Is : {Age.GetTypeCode()}");


            Console.WriteLine("Enter your age?");
            //if you dont convert you will get error, and if you enter string you will get error
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + (age+1));

            //Important: Console.ReadLine() always reads string.

            // Type your username and press enter
            Console.WriteLine("Enter username?");

            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);


            Console.WriteLine(WeekDays.Friday); //output: Friday 
            int day = (int)WeekDays.Friday; // enum to int conversion
            Console.WriteLine(day); //output: 4 

            var wd = (WeekDays)5; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday 


            ////In C#, there are two types of casting:
            ////Implicit Casting(automatically) -converting a smaller type to a larger type size
            ////char -> int -> long -> float -> double
            ////Explicit Casting(manually) - converting a larger type to a smaller size type
            ////double -> float -> long -> int -> char
            ///

            //Type Conversion Methods

            //It is also possible to convert data types explicitly by using built-in methods,
            //such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32(int)
            //and Convert.ToInt64(long)
            int myIn = 20;
            double myDoubl = 7.25;
            bool myBoo = true;

            Console.WriteLine(Convert.ToString(myIn));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myIn));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubl));  // convert double to int // 7
            Console.WriteLine(Convert.ToString(myBoo));   // convert bool to string


            double myDouble0 = 17.58;
            int myInt0 = (int)myDouble0;    // Manual casting: double to int

            Console.WriteLine(myDouble0);   // Outputs 17.58
            Console.WriteLine(myInt0);      // Outputs 17


            int myInt = 17;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 17
            Console.WriteLine(myDouble);   // Outputs 17

            short s = 10;

            int integer = s;
            byte b = (byte)s;

            s = b;

            Char ch = (char)b;

            b = (byte)ch;

            long l = integer;

            float f = b;

            f = s;

            f = integer;

            /* l = f;*/ //Compile Time Error You Could Not cast floating point data types (double , float) to the integeral numbers implicitily.

            l = (long)f;

            double d = b;

            d = l;

            d = f;

            l = (long)d;


            decimal dc = l;
            /*  dc = d;*/ //Compile Time Error You Could Not Cast Floating Point Date Types (double , float) to the Decimal number implicitily.
            /*  dc = f;*/ //Compile Time Error You Could Not Cast Floating Point Date Types (double , float) to the Decimal number implicitily.

            f = l;

            dc = (decimal)d;
            dc = (decimal)f;


            /*d = dc;*/ //You could implicitily casting decimal to double or float and vice versa you need explicitily done that..

            d = (double)dc;
            f = (float)dc;
        }
    }
}
