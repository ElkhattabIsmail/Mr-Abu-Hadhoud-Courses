using System;
using System.Reflection;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)] // AttributeUsage { Classes,Fields, Property,Constructor..}
public class RangeAttribute : Attribute
{
    public int Min { get; }
    public int Max { get; }

    public string ErrorMessage { get; set; }

    public RangeAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class StringLengthAttribute : Attribute
{
    public int Min { get; }
    public int Max { get; }

    public string ErrorMessage { get; set; }

    public StringLengthAttribute(int min, int max)
    {
        Min = min;
        Max = max;
    }
}
public class Person
{

    // added Meta-Date to age fields (additional info for age)
    [Range(18, 99, ErrorMessage = "Age must be between 18 and 99.")]
    public int Age { get; set; }

    [Range(20, 30, ErrorMessage = "Experience must be between 20 and 30.")]

    public int Experience { get; set; }

    [StringLength(2, 40, ErrorMessage = "Name must be between 2 and 40 Char.")]
    public string Name { get; set; }
}

public class ValidationExample
{
    public static void Main()
    {
        Person person = new Person { Age = 25, Name = "Es", Experience = 20 };

        if (ValidatePerson(person))
        {
            Console.WriteLine("Person is valid.");
        }
        else
        {
            Console.WriteLine("Validation failed.");
        }

        Console.ReadKey();

    }
    static bool ValidateTextLength(Person person, PropertyInfo property)
    {
        if (Attribute.IsDefined(property, typeof(StringLengthAttribute)))
        {
            var textLengthAttribute = (StringLengthAttribute)Attribute.GetCustomAttribute(property, typeof(StringLengthAttribute));
            string text = (string)property.GetValue(person);
            int value = text.Length;

            // Perform validation
            if (value < textLengthAttribute.Min || value > textLengthAttribute.Max)
            {
                Console.WriteLine($"Validation failed for property '{property.Name}': {textLengthAttribute.ErrorMessage}");
                return false;
            }
        }
        return true;
    }
    static bool ValidatePerson(Person person)
    {
        Type type = typeof(Person);

        foreach (var property in type.GetProperties())
        {
            // Check for RangeAttribute on properties
            if (property.PropertyType == typeof(string))
            {
                if (!ValidateTextLength(person, property))
                    return false;
            }
            else
            {
                if (Attribute.IsDefined(property, typeof(RangeAttribute)))
                {
                    var rangeAttribute = (RangeAttribute)Attribute.GetCustomAttribute(property, typeof(RangeAttribute));
                    int value = (int)property.GetValue(person);

                    // Perform validation
                    if (value < rangeAttribute.Min || value > rangeAttribute.Max)
                    {
                        Console.WriteLine($"Validation failed for property '{property.Name}': {rangeAttribute.ErrorMessage}");
                        return false;
                    }
                }
            }
           
           
        }

        return true;
    }
}
