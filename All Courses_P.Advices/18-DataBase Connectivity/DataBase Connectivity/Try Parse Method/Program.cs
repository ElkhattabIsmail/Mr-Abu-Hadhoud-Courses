using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Try_Parse_Method
{
    internal class Program
    {
//        result.ToString(): The ToString() method is called on the variable or object named result.This method
//        converts the value of result to 
//            its string representation.For example, if result is an integer, this method converts it to a string.

//int.TryParse(): This is a method used to parse a string representation of a number (in this case, 
//obtained from result.ToString()) and attempts to convert it to an integer(int). It checks if the string is a valid integer
//and returns a boolean 
//            value indicating whether the conversion was successful(true) or not(false).

//out int InsertedId: This part involves declaring an int variable named InsertedId.The 
//            out keyword is used here because int.TryParse is designed to return a boolean 
//value indicating success or failure of the conversion. However, it also has an out parameter (the InsertedId variable) 
//            that captures the converted integer value if the parsing is successful.

//The int.TryParse() method is commonly used when you want to convert a string to an integer but want to handle 
//            potential failures gracefully without throwing an exception.If the conversion succeeds, the converted 
//            integer value will be stored in the InsertedId variable, and the method will return true. If the conversion
//            fails(e.g., if the string isn't a valid integer representation), it will return false, and InsertedId will 
//                contain the default value of int (which is 0).
        public static int IntParseFast(string value)
        {
            // An optimized int parse method.
            int result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                result = 10 * result + (value[i] - 48);
            }
            return result;
        }
        const int _max = 1000000;
        static void Main(string[] args)
        {

            // Test the methods.
            Console.WriteLine(IntParseFast("123456"));
            Console.WriteLine(int.Parse("123456"));

            var s1 = Stopwatch.StartNew();
            // Version 1: use custom parsing algorithm.
            for (int i = 0; i < _max; i++)
            {
                int result = IntParseFast("123456");
            }
            s1.Stop();
            var s2 = Stopwatch.StartNew();
            // Version 2: use int.Parse.
            for (int i = 0; i < _max; i++)
            {
                int result = int.Parse("123456");
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            }
        }
            //123456
            //123456
            // 3.76 ns:    IntParseFast
            //20.31 ns:    int.Parse

        //Errors.The int.Parse method is strict.With an invalid string, it throws  
        //    a FormatException.We can catch this using a try-catch construct.
        //But Using the int.TryParse method is usually a better solution. TryParse is faster.

        //// code
        //string input = "carrot";
        //// ... This will throw an exception.
        //int carrots = int.Parse(input);
        //Console.WriteLine(carrots);





        // See if we can parse the string.
        //string text1 = "x";
        //int num1;
        //bool res = int.TryParse(text1, out num1);
        //if (res == false)
        //{
        //    // String is not a number.
        //}

        //// Use int.TryParse on a valid numeric string.
        //string text2 = "10000";
        //int num2;
        //if (int.TryParse(text2, out num2))
        //{
        //    // It was assigned.
        //}

        //// Display both results.
        //Console.WriteLine(num1);
        //Console.WriteLine(num2);
        // output num1 = 0 , num 2 = 10000




        //            TryParse with no if.Usually we call int.TryParse inside an 
        //                if-statement.But this is not required.And sometimes, we can just 
        //                treat a failed parse as the default value(0 for int).
        //Tip This removes a branch in our code—we can just use the result, not test it. 
        //                Branches are good for trees, but bad for performance.

        //string error = "Welcome";
        //// This will leave the result variable with a value of 0.
        //int result;
        //int.TryParse(error, out result);
        //Console.WriteLine(result);


        // try parse with date time
        //string now = "1/22/2017";
        //// Use TryParse on the DateTime type to parse a date.
        //DateTime parsed;
        //if (DateTime.TryParse(now, out parsed))
        //{
        //    Console.WriteLine(parsed);
        //}
        // output = 1 / 22 / 2017 12:00:00 AM




        //const int _max = 10000;
        ////// Version 1: parse an invalid string with exception handling.
        //var s1 = Stopwatch.StartNew();
        ////for (int i = 0; i < _max; i++)
        ////{
        ////    int result;
        ////    try
        ////    {
        ////        result = int.Parse("abc");
        ////    }
        ////    catch
        ////    {
        ////        result = 0;
        ////    }
        ////}
        ////s1.Stop();

        //// Version 2: parse an invalid string with TryParse.
        //var s2 = Stopwatch.StartNew();
        //for (int i = 0; i < _max; i++)
        //{
        //    int result;
        //    int.TryParse("abc", out result);
        //}
        //s2.Stop();
        //Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
        //Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
    }

