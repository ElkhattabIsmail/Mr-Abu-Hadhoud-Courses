using System;

public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public abstract void Introduce();

    public void SayGoodbye()
    {
        Console.WriteLine("Goodbye!");
    }
}

public class Employee : Person
{
    public int EmployeeId { get; set; }

    public override void Introduce()
    {
        Console.WriteLine($"Hi, my name is {FirstName} {LastName}, and my employee ID is {EmployeeId}.");
    }
}

//2 / 2
//Abstract method: can only be used in an abstract class, and it does not have a body. 
//    The body is provided by the derived class (inherited from).
public class Program
{
//    Abstract class and private class
//الفرق ان Abstract class
//object مينفعش تعمل منها
//لازم تورث لحد عشان تسخدم الخواص بتاعتها
//بس private class
//برضوا بس الفرق object مينفعش تعمل منها
//انها بتسعملها جوه الكلاس بس
    public static void Main()
    {
        //You cannot create an object of an abstract class, you can only inherit it.
        //  Person Person1= new Person();

        Employee employee = new Employee();
        employee.FirstName = "Mohammed";
        employee.LastName = "Abu-Hadhoud";
        employee.EmployeeId = 123;
        employee.Introduce(); // Output: "Hi, my name is John Doe, and my employee ID is 123."
        employee.SayGoodbye(); // Output: "Goodbye!"

        Console.ReadKey();
    }
}