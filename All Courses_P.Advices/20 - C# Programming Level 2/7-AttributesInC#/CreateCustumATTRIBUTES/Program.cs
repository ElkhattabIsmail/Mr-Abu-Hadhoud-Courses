using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method /*| AttributeTargets.Field*/, AllowMultiple = true)]
//AttributeTargets.Method in this case) and whether it can be applied multiple times to the same element(AllowMultiple = true).
public class MyCustomAttribute : Attribute
{
    public string Description { get; }

    public MyCustomAttribute(string description)
    {
        Description = description;
    }
}
[MyCustom("This is a class attribute")]
class MyClass
{
    [MyCustom("This is a method attribute")]
    public void MyMethod()
    {
        // Method implementation
    }
}
namespace Custom
{
    class Program
    {
        static void Main()
        {

        }
    }
}
