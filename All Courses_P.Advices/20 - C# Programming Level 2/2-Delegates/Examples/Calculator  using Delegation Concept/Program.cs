using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator__using_Delegation_Concept
{
    public class Calculator
    {
        public delegate void Caculate(int N1, int N2);

        private Caculate _Calculator;

        public Calculator( Caculate calculator) // Take the Function
        {
            _Calculator = calculator;
        }

        public void InserMethod(int N1, int N2) // Call the Function
        {
            _Calculator(N1, N2);
        }
    }
    internal class Program
    {
        public static void Somme(int N1, int N2)
        {
            Console.WriteLine(N1 + N2);
        }
        public static void Multiple(int N1, int N2)
        {
            Console.WriteLine(N1 * N2);
        }
        static void Main(string[] args)
        {
            Calculator Sum = new Calculator(Somme);
            Sum.InserMethod(1, 2);
            Calculator Multiplication = new Calculator(Multiple);
            Multiplication.InserMethod(5, 4);
            Console.ReadLine();
        }
    }
}
