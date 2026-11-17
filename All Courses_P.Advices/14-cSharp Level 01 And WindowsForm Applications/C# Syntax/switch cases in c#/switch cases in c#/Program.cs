
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;
using System.Collections.Generic;

namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {

            char ch;
            Console.WriteLine("Enter a letter?");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
            //switch statement with grouped cases

            char ch1;
            Console.WriteLine("Enter a letter");
            ch1 = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch1))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }

            //Console.Write("Enter first number: ");
            //f = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //s = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter operator (+, -, *, /): ");

            //op = (char)Console.Read();

            //switch (op)
            //{
            //    case '+':
            //        result = first + second;
            //        Console.WriteLine("{0} + {1} = {2}", first, second, result);
            //        break;

            //    case '-':
            //        result = first - second;
            //        Console.WriteLine("{0} - {1} = {2}", first, second, result);
            //        break;

            //    case '*':
            //        result = first * second;
            //        Console.WriteLine("{0} * {1} = {2}", first, second, res);
            //        break;

            //    case '/':
            //        res = first / second;
            //        Console.WriteLine("{0} / {1} = {2}", first, second, res);
            //        break;

            //    default:
            //        Console.WriteLine("Invalid Operator");
            //        break;

            //}

            string Name = "Mohammed";

            //You can compare string as well using switch
            switch (Name.ToLower())
            {
                case "mohammed":

                    Console.WriteLine("Yes Mohammed");
                    break;

                case "ali":

                    Console.WriteLine("Yes ALi");
                    break;

                default:
                    Console.WriteLine("No Name Matched!");
                    break;

            }
            Console.ReadKey();

        }
    }
}

