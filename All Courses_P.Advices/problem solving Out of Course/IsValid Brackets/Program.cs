using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IsValid_Brackets
{
    internal class Program
    {
        static bool IsValidChar(char a , char b)
        {
            if (a == '(' )
                return  a + 1 == b;
            else
                return a + 2 == b;
        }
        static bool IsValidBracktes(string Str)
        {
            // () [] {}
            // test -> () (())
            //  ( ) ( { { } } )
            Stack<char> stack = new Stack<char>();
            string ValidChar = "()[]{}";
            foreach (char c in Str)
            {
                //if (c == '(' || c == '[' || c == '{' ) 
                //    stack.Push(c);
                // OR
                if ("([{".Contains (c))
                    stack.Push(c);
                else
                {
                    if (!ValidChar.Contains(c))
                        continue;
                    if (stack.Count > 0 && IsValidChar(stack.First() , c))
                        stack.Pop();
                    else
                        return false;
                }
            }
            return stack.Count == 0;
        }
        static void Main(string[] args)
        {
             
            string TestCase = " ()({{}})";

            if (IsValidBracktes(TestCase))
                Console.WriteLine("Valid");
        }
    }
}
