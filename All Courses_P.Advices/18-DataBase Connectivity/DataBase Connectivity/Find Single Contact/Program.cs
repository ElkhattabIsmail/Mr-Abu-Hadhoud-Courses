using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;

public class Program
{
    static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;"; // Replace with your actual connection string

    public struct StContact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
    }

    static bool FindContactByID(int ContactID ,ref StContact contactInfo)
    {
        
        SqlConnection connection = new SqlConnection(connectionString);

        string query = "select * from Contacts\r\nwhere ContactID = @ContactID";

        bool isfound = false;

        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@ContactID", ContactID);

        try
        {
            connection.Open();

            SqlDataReader Reader = command.ExecuteReader();  // First Column From First Row from Qwery

            if (Reader.Read())
            {
                // Record was found
                isfound = true;
                contactInfo.ID = (int)Reader["ContactID"]; // 0 1 2 3 4 5
                contactInfo.FirstName = Reader["FirstName"].ToString();
                contactInfo.LastName = Reader["LastName"].ToString();
                contactInfo.Email = Reader["Email"].ToString();
                contactInfo.Phone = Reader["Phone"].ToString();
                contactInfo.Address = Reader["Address"].ToString();
                contactInfo.CountryID = (int)Reader["countryID"];

            }
            else
                isfound = false;

            Reader.Close();
            connection.Close();   // try to get hare

        }

        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        return isfound;
       
    }







    public static void Main()
    {
        StContact ContactInfos = new StContact();

        if (FindContactByID (6 ,ref ContactInfos))
        {
            Console.WriteLine(ContactInfos.ID);
            Console.WriteLine(ContactInfos.FirstName);
            Console.WriteLine(ContactInfos.LastName );
            Console.WriteLine(ContactInfos.Email );
            Console.WriteLine(ContactInfos.Phone );
            Console.WriteLine(ContactInfos.Address );
            Console.WriteLine(ContactInfos.CountryID);
        }
        else
            Console.WriteLine("Not Found !");

        Console.ReadKey();
    }

}
