using System;
using System.IO;
using System.Xml.Serialization;


[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
public class ClsUser
{
    [XmlElement("UserName")]
    public string UserName { get; set; }

    [XmlElement("Password")]
    public string Password { get; set; }
    public ClsUser() { } 
   
    public ClsUser(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person { Name = "Elkhattab Smail", Age = 24 };
        // XML serialization
        XmlSerializer serializer = new XmlSerializer(typeof(Person));
        using (TextWriter writer = new StreamWriter("person.xml"))
        {
            serializer.Serialize(writer, person);
        }
        // Deserialize the object back
        using (TextReader reader = new StreamReader("person.xml"))
        {
            Person deserializedPerson = (Person)serializer.Deserialize(reader);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }



        ClsUser User = new ClsUser("User1", "1234");
        // XML serialization for User
        XmlSerializer SerialzedUser = new XmlSerializer(typeof(ClsUser));
        using (TextWriter writer = new StreamWriter("User.xml"))
        {
            SerialzedUser.Serialize(writer, User);
        }
        //Deserialize the object back
        using (TextReader reader = new StreamReader("User.xml"))
        {
            ClsUser deserializedClsUser = (ClsUser)SerialzedUser.Deserialize(reader);
            Console.WriteLine($"UserName: {deserializedClsUser.UserName}, Password: {deserializedClsUser.Password}");
        }
        Console.ReadKey();
    }
}

//Method Best Use Case	Supports Parameterized Constructor?	.NET Compatibility
//System.Text.Json	Modern .NET apps, simple JSON	✅ Yes (with [JsonConstructor])	.NET 5+
//Newtonsoft.Json	Best for older .NET versions or advanced JSON handling	✅ Yes (with [JsonConstructor])	.NET Framework, .NET Core, .NET 5+
//XmlSerializer	XML format needed (e.g., legacy systems)	❌ No (requires parameterless constructor)	Any .NET version