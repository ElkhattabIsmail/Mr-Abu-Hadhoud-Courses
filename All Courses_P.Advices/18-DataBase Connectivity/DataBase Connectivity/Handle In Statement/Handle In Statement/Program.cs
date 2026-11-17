using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;
using System.Collections.Generic;

public class Program
{
    static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=123456;"; // Replace with your actual connection string

    static void DeleteContacts(List<int> ContactIDs)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Build the query dynamically with parameters
            string query = "Delete from Contacts Where ContactID in (";
            for (int i = 0; i < ContactIDs.Count; i++)
            {
                if (i > 0)
                {
                    query += ", ";
                }
                query += "@ContactID" + i;
            }
            query += ")";

            SqlCommand command = new SqlCommand(query, connection);

            // Add parameters to the command
            for (int i = 0; i < ContactIDs.Count; i++)
            {
                command.Parameters.AddWithValue("@ContactID" + i, ContactIDs[i]);
            }
        }
    }


            static void DeleteContacts(string ContactIDs)
         {

        SqlConnection connection = new SqlConnection(connectionString);
      
        string query = @"Delete Contacts 
                                where ContactID in (" + ContactIDs + ")";

        SqlCommand command = new SqlCommand(query, connection);
            
             
                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Record Deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No Records Deleted.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

        connection.Close();
    }

    public static void Main()
    {

       
        DeleteContacts("8,9,10");

        Console.ReadKey();

    }

}
