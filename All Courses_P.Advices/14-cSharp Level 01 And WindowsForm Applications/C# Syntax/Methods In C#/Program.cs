
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;


//Information can be passed to methods as parameter. Parameters act as variables inside the method.
//They are specified after the method name, inside the parentheses. You can add as many parameters 
//as you want, just separate them with a comma.
namespace Main
{
    internal class Program
    {
        static void PrintMyInfos(string Name, byte Age, string Address = "No Address")
        {
            Console.WriteLine("Name= {0} , Age= {1}, Address= {2}", Name, Age, Address);
        }
        static void PrintMyInfo(string Name, byte Age)
        {
            Console.WriteLine("Name= {0} , Age= {1}", Name, Age);
        }
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static int Sum(int Num1, int Num2)

        {
            return Num1 + Num2;
        }

        static int Sum(int Num1, int Num2, int Num3)

        {
            return Num1 + Num2 + Num3;
        }
        static int Sum(int Num1, int Num2, int Num3, int Num4)

        {
            return Num1 + Num2 + Num3 + Num4;
        }
        static void Main(string[] args)
        {


            //PrintMyInfo("Mohammed-AbuHadhoud", 45);

            ////You can also use a default parameter value, by using the equals sign(=).
            ////First we did not provide the address it's optional
            //PrintMyInfos("Mohammed-AbuHadhoud", 45);
            ////second we provided the address
            //PrintMyInfos("Mohammed-AbuHadhoud", 45, "Amman-Jordan");

            ////It is also possible to send arguments with the key: value syntax.
            ////That way, the order of the arguments does not matter.

            ////see the order of sending parameters is not important.

            //MyMethod(child1: "Omar", child3: "Saqer", child2: "Hamza");

            ////With method overloading, multiple methods can have the same name with different parameters.
            ////we have 3 diffrent methods but with the same name.

            //Console.WriteLine(Sum(10, 20));
            //Console.WriteLine(Sum(10, 20, 30));
            //Console.WriteLine(Sum(10, 20, 30, 40));


            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            // you can do multiple catch block
            catch (Exception e) // All Exeptions 
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }

            //Use the Next(int min, int max) overload method to get a random integer that is within a specified range.


            Random rnd = new Random();

            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(rnd.Next(10, 20)); // returns random integers >= 10 and < 20
            }



            Console.ReadLine();

            Console.ReadKey();

        }
    }
}


