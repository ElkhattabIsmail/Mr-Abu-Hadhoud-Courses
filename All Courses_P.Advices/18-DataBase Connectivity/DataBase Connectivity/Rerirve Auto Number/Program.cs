using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Add_Data_to_Data_Base
{
    internal class Program
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

        static void AddNewContactAndGetID(StContact Contact)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"INSERT INTO Contacts (FirstName,LastName,Email,Phone,Address,CountryID) 
                VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@CountryID);
                select SCOPE_IDENTITY();";
            // to select statements 

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
            command.Parameters.AddWithValue("@LastName", Contact.LastName);
            command.Parameters.AddWithValue("@Email", Contact.Email);
            command.Parameters.AddWithValue("@Phone", Contact.Phone);
            command.Parameters.AddWithValue("@Address", Contact.Address);
            command.Parameters.AddWithValue("@CountryID", Contact.CountryID);

            try
            {
                connection.Open();
                Object  Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int isertedID))
                {
                    Console.WriteLine($"Now Inserted ID : {isertedID}");
                }
                else
                {
                    Console.WriteLine("Inserted Failed");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

            connection.Close();
        }
        static void Main(string[] args)
        {

            StContact Contact = new StContact()
            {
                FirstName = "Smail",
                LastName = "khattab",
                Email = "Whatever",
                Phone = "000000",
                Address = "Last idendity added",
                CountryID = 4
            };
            AddNewContactAndGetID(Contact);
        }
    }
}
