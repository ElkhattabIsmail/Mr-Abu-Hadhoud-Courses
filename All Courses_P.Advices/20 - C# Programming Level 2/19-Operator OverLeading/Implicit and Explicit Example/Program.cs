using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_and_Explicit_Example
{
    //❌ Not Allowed: Conversion Between Two Primitive Types
    //Cannot overload implicit/explicit operators for built-in types like int to float.

    class InvalidConversion
    {
        // ❌ ERROR: Cannot overload conversion between primitive types

        //public static implicit operator float(int value) => (float)value;  // error
    }
    class MyNumber
    {
        public int Value;
        public MyNumber(int val) { Value = val; }

        // ✅ Implicit conversion from MyNumber to int
        public static implicit operator int(MyNumber obj) => obj.Value;

        // ✅ Explicit conversion from int to MyNumber
        public static explicit operator MyNumber(int val) => new MyNumber(val);
    }


    class Celsius
    {
        public double Temperature { get; }

        public Celsius(double temp) { Temperature = temp; }

        // ✅ Implicit conversion from Celsius to Fahrenheit
        public static implicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((c.Temperature * 9 / 5) + 32);
        }
    }
    class Fahrenheit
    {
        public double Temperature { get; }

        public Fahrenheit(double temp) { Temperature = temp; }

        // ✅ Explicit conversion from Fahrenheit to Celsius
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.Temperature - 32) * 5 / 9);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius c = new Celsius(25);

            Fahrenheit f = c;  // ✅ Implicit conversion (Celsius → Fahrenheit)
            Console.WriteLine(f.Temperature);  // Output: 77°F

            Fahrenheit f2 = new Fahrenheit(100);
            Celsius c2 = (Celsius)f2;  // ✅ Explicit conversion (Fahrenheit → Celsius)
            Console.WriteLine(c2.Temperature);  // Output: 37.77°C


            //✅ Fix: Use normal type casting instead:
            int x = 10;
            float y = (float)x;  // ✅ Works using built-in casting
            // for example 1


            MyNumber obj = new MyNumber(50);
            int num = obj;  // ✅ Implicit conversion (automatic)

            MyNumber newObj = (MyNumber)100;  // ✅ Explicit conversion (requires cast)

            Console.WriteLine(num);      // Output: 50
            Console.WriteLine(newObj.Value);  // Output: 100

            // Summary :
            //User - defined type ⇄ Primitive type	✅ Yes MyClass → int, int → MyClass
            //User - defined type ⇄ Another user-defined type   ✅ Yes ClassA → ClassB, ClassB → ClassA
            //Primitive type ⇄ Primitive type	❌ No    int → float, double → int
        }
    }
}