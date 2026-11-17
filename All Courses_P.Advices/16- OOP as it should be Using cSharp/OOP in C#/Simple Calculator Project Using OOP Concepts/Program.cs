using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator_Project_Using_OOP_Concepts
{
    internal class Program
    {
        class clsCalculator
        {
            private float _Result = 0;
            private string _OPtype = String.Empty;
            private float _LastNumber;

            public void Clear()
            {
                _Result = 0;
                _OPtype = "Clear";
                _LastNumber = 0;
            }
            public float Add(float Num)
            {
                _LastNumber = Num;
                _OPtype = "Adding";
                _Result += Num;
                return _Result;
            }
            public float Subtract(float Num)
            {
                _LastNumber = Num;
                _OPtype = "Subtracting";
                _Result -= Num;
                return _Result;
            }
            public float Multiply(float Num)
            {
                _LastNumber = Num;
                _OPtype = "Multipling";
                _Result *= Num;
                return _Result;
            }
            public float Divide(float Num)
            {
                _LastNumber = Num;
                _OPtype = "Dividing";
                if (Num == 0)
                    return _Result;
                _Result /= Num;
                return _Result;
            }
            public void PrintResult()
            {
                if (_LastNumber > 0)
                {
                    Console.WriteLine($"Result After {_OPtype} {_LastNumber} is : {_Result}");
                }
                else
                {
                    Console.WriteLine($"Result After {_OPtype} is : {_Result}");
                }
                
            }

        }
        static void Main(string[] args)
        {
            clsCalculator Calculato1 = new clsCalculator();

            Calculato1.Clear();

            Calculato1.Add(10);
            Calculato1.PrintResult();

            Calculato1.Add(100);
            Calculato1.PrintResult();

            Calculato1.Subtract(20);
            Calculato1.PrintResult();

            Calculato1.Divide(0);
            Calculato1.PrintResult();

            Calculato1.Divide(2);
            Calculato1.PrintResult();

            Calculato1.Multiply(3);
            Calculato1.PrintResult();

            Calculato1.Clear();
            Calculato1.PrintResult();

            Console.ReadLine();
        }
    }
}
