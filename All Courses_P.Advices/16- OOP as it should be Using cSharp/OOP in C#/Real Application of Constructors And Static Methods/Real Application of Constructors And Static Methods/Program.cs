using System;

class clsPerson
{
    public int ID { get; set; }
    public string Name { get; set; }
    public byte Age { get; set; }

    public clsPerson(int ID, string Name, byte Age)
    {
        this.ID = ID;
        this.Name = Name;
        this.Age = Age;
    }

    public static clsPerson Find(int ID)
    {
        if (ID == 10)
            return new clsPerson(10, "Mohammed Abu-Hadhoud", 45);
        else
            return null;
    }

       // الاوبجيكب يخلق في الكلاس نفسها
    public static clsPerson Find(string UserName, string PassWord)
    {
        if (UserName == "user3" && PassWord == "a1234")
            return new clsPerson(10, "Mohammed Abu-Hadhoud", 45);
        else
            return null;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        //clsPerson Person1 = new clsPerson(10, "Mohammed Abu-Hadhoud", 45);

        Console.WriteLine("Finding person1 by ID");
        clsPerson person1 = clsPerson.Find(10);

        //Console.WriteLine("ID   : {0}", person1.ID);

        if (person1 != null)
        {
            Console.WriteLine("ID   : {0}", person1.ID);
            Console.WriteLine("Name : {0}", person1.Name);
            Console.WriteLine("Age  : {0}", person1.Age);
        }
        else
            Console.WriteLine("Could not find the person by the givin ID");



        Console.WriteLine("\n\nFinding person2 by UserName & PassWord");
        clsPerson person2 = clsPerson.Find("user3", "a1234");

        if (person2 != null)
        {
            Console.WriteLine("ID   : {0}", person2.ID);
            Console.WriteLine("Name : {0}", person2.Name);
            Console.WriteLine("Age  : {0}", person2.Age);
        }
        else
            Console.WriteLine("Could not find the person by the givin UserName & PassWord");


        Console.ReadKey();
    }
}