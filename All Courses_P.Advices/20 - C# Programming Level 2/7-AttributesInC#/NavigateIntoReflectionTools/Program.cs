using System;
using System.Linq;
using System.Reflection;

namespace MyNameSpace
{

    public class MyClass
    {
        public int Property1 { get; set; }

        public void Method1()
        {
            Console.WriteLine("\tMethod1 is Executed");
        }

        public void Method2(int value1, string value2)
        {
            Console.WriteLine($"\tMethod2 is Executed with parameters: {value1}, {value2}");
        }
    }

    class Program
    {
        static string GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }

        static void Main()
        {
            // Get the type information for Type
            Type ClsType = typeof(Type);
            Console.WriteLine($"Type Name: {ClsType.Name}");
            Console.WriteLine($"Full Name: {ClsType.FullName}");

            // Get the properties of MyClass
            Console.WriteLine("\nProperties:");
            foreach (var property in ClsType.GetProperties())
            {
                Console.WriteLine($"Property Name: {property.Name}, Type: {property.PropertyType}");
            }

            // Get the methods of ClsType
            Console.WriteLine("\nMethods:\n");
            foreach (var method in ClsType.GetMethods(BindingFlags.Public | BindingFlags.Instance))
            {
                Console.WriteLine($"\t{method.ReturnType} {method.Name}({GetParameterList(method.GetParameters())})");
            }


            // Create an instance of ClsType
            object myClassInstance = Activator.CreateInstance(ClsType);

            //MethodInfo Method = ClsType.GetMethod(Method.Name)
            ClsType.GetMethod("Method1").Invoke(myClassInstance, null);
            //// Set the value of Property1 using reflection
            //ClsType.GetProperty("Property1").SetValue(myClassInstance, 42);
            //Console.WriteLine("\nSet Property1 to 42 using reflection:");


            //// Get the value of Property1 using reflection
            //Console.WriteLine("\nGetting Property1 is value using reflection:");
            //int Property1Value = (int)ClsType.GetProperty("Property1").GetValue(myClassInstance);
            //Console.WriteLine($"\tProperty1 Value: {Property1Value}");


            ////now how to execute methods using reflection:
            //Console.WriteLine("\nExecuting Methods using reflection:\n");

            //// Invoke the Method1 using reflection
            //ClsType.GetMethod("Method1").Invoke(myClassInstance, null);

            //// Invoke Method2 with parameters using reflection
            //object[] parameters = { 100, "Mohammed Abu-Hadhoud" };
            //ClsType.GetMethod("Method2").Invoke(myClassInstance, parameters);

            Console.ReadKey();

        }
    }

}
