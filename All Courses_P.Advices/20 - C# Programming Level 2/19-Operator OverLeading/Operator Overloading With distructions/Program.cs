using System.IO;
using System.Security.Claims;
using System;




class Program
{
    //Examples of Operators with Restrictions in C#
    //Some operators can be overloaded but have restrictions. Below are examples of these restrictions:

    //1️⃣ = (Assignment Operator) - Cannot Be Overloaded Directly
    //The assignment operator = cannot be overloaded.
    //However, you can define a conversion operator that indirectly affects assignment.
    //✅ Allowed: Overloading conversion operators (implicit/explicit)
    //❌ Not Allowed: Directly overloading =

    //Example: Overloading a Conversion to Affect Assignment
    class MyClass
    {
        public int Value;

        public MyClass(int value)
        {
            Value = value;
        }

        // ✅ Overloading conversion from MyClass to int
        public static implicit operator int(MyClass obj)
        {
            return obj.Value;
        }
    }
    //2️⃣ ?: (Ternary Conditional) - Restriction on Operand Types
    //You cannot overload the ?: operator itself.
    //However, if the second and third operands are user-defined types, they must be the same type.
    //✅ Allowed: Second and third operands must be the same type
    //❌ Not Allowed: Overloading?: directly

    //Example: Restriction on Ternary Operator Operand Types
    class MyClass1
    {
        public int Value;
        public MyClass1(int val) { Value = val; }
    }


    //3️⃣ Unary Operators(+, -) -Restricted for Integer Types
    //Some unary operators(+, -) cannot be overloaded for primitive integer types(bool, byte, short, etc.).
    //✅ Allowed: Overloading + and - for custom classes
    //❌ Not Allowed: Overloading for bool, byte, short, etc.
    //Example: Overloading + for a Custom Class
    class MyNumber
    {
        public int Value;

        public MyNumber(int val)
        {
            Value = val;
        }

        // ✅ Overloading the unary `+` operator
        public static MyNumber operator +(MyNumber num)
        {
            return new MyNumber(+num.Value);
        }
    }

    //4️⃣ Binary Operators(+=, -=, etc.) -Depend on the Corresponding Binary Operator
    //Operators like +=, -= cannot be directly overloaded.
    //Instead, their behavior is determined by the corresponding binary operator (+, -, etc.).
    //✅ Allowed: Overloading +, -affects +=, -=
    //❌ Not Allowed: Overloading += directly

    //Example: Overloading + to Affect +=

    class MyNumber2
    {
        public int Value;
        public MyNumber2(int val) { Value = val; }

        // ✅ Overloading binary `+`
        public static MyNumber2 operator +(MyNumber2 a, MyNumber2 b)
        {
            return new MyNumber2(a.Value + b.Value);
        }
    }


    //5️⃣ Equality and Comparison (==, !=, <, >, <=, >=) - Must Be Overloaded in Pairs
    //If you overload ==, you must also overload !=.
    //Similarly, if you overload <, you must also overload >.
    //✅ Allowed: Overloading == requires overloading !=
    //❌ Not Allowed: Overloading == without !=

    //Example: Overloading == and != Together

    class MyNumberClass
    {
        public int Value;
        public MyNumberClass(int val) { Value = val; }

        // ✅ Overloading `==`
        public static bool operator ==(MyNumberClass a, MyNumberClass b)
        {
            return a.Value == b.Value;
        }

        // ✅ Overloading `!=`
        public static bool operator !=(MyNumberClass a, MyNumberClass b)
        {
            return a.Value != b.Value;
        }
    }

    //6️⃣ Indexing Operator([]) -Can Only Be Overloaded in Classes with an Indexer
    //The indexing operator [] can only be overloaded using an indexer property.
    //It does not work for primitive types.
    //✅ Allowed: Overloading[] in a class with an indexer
    //❌ Not Allowed: Overloading[] in primitive types

    //Example: Overloading[] in a Class

    class MyCollection
    {
        private int[] data = new int[5];

        // ✅ Overloading `[]` using an indexer
        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
    }

    //7️⃣ Conversion Operators(implicit, explicit) -Restricted to User-Defined Types
    //implicit and explicit conversion operators can only be overloaded for user-defined types.
    //You cannot overload conversions involving primitive types only.
    //✅ Allowed: Converting between user-defined types
    //❌ Not Allowed: Converting between primitive types

    //Example: Overloading implicit Conversion

    class MyNumberClass2
    {
        public int Value;
        public MyNumberClass2(int val) { Value = val; }

        // ✅ Overloading implicit conversion from MyNumberClass to int
        public static implicit operator int(MyNumberClass2 obj)
        {
            return obj.Value;
        }
    }

    static void Main()
    {
        MyClass obj = new MyClass(10);
        int x = obj;  // ✅ Implicit conversion instead of overloading `=`
        Console.WriteLine(x); // Output: 10


        MyClass1 obj1 = new MyClass1(10);
        MyClass1 obj2 = new MyClass1(20);
        // ✅ Allowed (both operands are MyClass objects)
        MyClass1 result = (true) ? obj1 : obj2;
        // ❌ Not allowed (inconsistent operand types)
        // int result2 = (true) ? obj1 : 5;  // Compiler error
        Console.WriteLine(result.Value); // Output: 10


        MyNumber num = new MyNumber(10);
        MyNumber result1 = +num; // ✅ Works for custom type
        Console.WriteLine(result1.Value); // Output: 10


        MyNumber2 nm = new MyNumber2(10);
        MyNumber2 nm1 = new MyNumber2(20);
        nm += nm1; // ✅ Uses overloaded `+`
        Console.WriteLine(nm.Value); // Output: 30


        MyNumberClass num1 = new MyNumberClass(10);
        MyNumberClass num2 = new MyNumberClass(10);
        Console.WriteLine(num1 == num2); // Output: True
        Console.WriteLine(num1 != num2); // Output: False


        MyCollection collection = new MyCollection();
        collection[0] = 100; // ✅ Uses overloaded `[]`

        Console.WriteLine(collection[0]); // Output: 100


        MyNumberClass2 obj3 = new MyNumberClass2(50);
        int num3 = obj3; // ✅ Works because of implicit conversion
        Console.WriteLine(num); // Output: 50

    }
}

//🔹 Summary of Restrictions
//Operator	Restriction
//=	Cannot be overloaded directly, only via conversion operators
//?:	Operands must be the same type
//+, -	Cannot be overloaded for primitive types
//+=, -=	Behavior depends on +, - overloading
//==, !=	Must be overloaded together
//<, >	Must be overloaded together
//[] Can only be overloaded in classes with indexers
//implicit, explicit	Can only convert user-defined types
