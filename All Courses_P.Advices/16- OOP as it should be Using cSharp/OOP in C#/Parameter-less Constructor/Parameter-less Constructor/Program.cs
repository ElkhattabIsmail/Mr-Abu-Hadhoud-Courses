using System;

class clsPerson
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string LastName { get; set; }



    // Constructor Without Parameter
    public clsPerson()
    {

        LastName = "Elkhattab";
        // Do anyThings here ( save on datebase...)
        Id = -1;
        Name = "Empty";
        Age = 0;
        
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        clsPerson Person1 = new clsPerson();
        Person1.Name = "ismail";

        Console.WriteLine("ID = {0}", Person1.Id);

        Console.WriteLine("Name = {0}", Person1.Name);
        Console.WriteLine("Age = {0}", Person1.Age);
        Console.ReadKey();
    }
}
