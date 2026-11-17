using System;
using System.Reflection;

class Program
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class MyCustomAttribute : Attribute
    {
        public string Description { get; }
        public DateTime AttributeDate { get; }

        public MyCustomAttribute(string description)
        {
            Description = description;
            AttributeDate = DateTime.Now;
        }
    }

    [MyCustom("This is a class attribute 4 Test.")]
    class MyClass
    {
        [MyCustom("This is a method attribute Doesn't do anything for now.")]
        public void MyMethod()
        {
            // Method implementation
        }
    }

    static void Main()
    {
        // Get the type of MyClass
        Type type = typeof(MyClass);

        // Get class-level attributes
        object[] classAttributes = type.GetCustomAttributes(typeof(MyCustomAttribute), false);
       
        foreach (MyCustomAttribute attribute in classAttributes)
        {
            Console.WriteLine($"Class Attribute: {attribute.Description}");
            Console.WriteLine($"Date: {attribute.AttributeDate}");
        }

        Console.WriteLine($"Methods Name:\n");

        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine($"Method Name:\n {method.Name}");
            Console.WriteLine($"Date: {DateTime.Now}");
        }
        // Get method-level attributes
        MethodInfo methodInfo = type.GetMethod("MyMethod");
        object[] methodAttributes = methodInfo.GetCustomAttributes(typeof(MyCustomAttribute), false);
       
        foreach (MyCustomAttribute attribute in methodAttributes)
        {
            Console.WriteLine($"Method Attribute : {attribute.Description}");
            Console.WriteLine($"Method Attribute Date:  {attribute.AttributeDate}");

        }

        Console.ReadKey();

    }
}