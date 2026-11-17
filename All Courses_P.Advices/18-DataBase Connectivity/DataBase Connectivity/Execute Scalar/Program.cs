using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;

public class Program
{
    static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;"; // Replace with your actual connection string



    static string GetFirstNameByID(int ContactID)
    {
        string FirstName = "";
        SqlConnection connection = new SqlConnection(connectionString);

        string query = "select FirstName from Contacts\r\nwhere ContactID = @ContactID";


        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@ContactID", ContactID);

        try
        {
            connection.Open();

            Object Result = command.ExecuteScalar();  // First Column From First Row from Qwery

            if (Result != null)
            {
                FirstName = Result.ToString();
            }
            else
                FirstName = "";

            connection.Close();   // try to get hare

        }


        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        return FirstName;
    }







    public static void Main()
    {
        Console.WriteLine( GetFirstNameByID(3));
        Console.ReadKey();
    }

}
