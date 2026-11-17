using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        static void AddNewContact(StContact Contact)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"INSERT INTO Contacts (FirstName,LastName,Email,Phone,Address,CountryID) 
                VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@CountryID)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", Contact.FirstName );
            command.Parameters.AddWithValue("@LastName", Contact.LastName );
            command.Parameters.AddWithValue("@Email", Contact.Email );
            command.Parameters.AddWithValue("@Phone", Contact.Phone );
            command.Parameters.AddWithValue("@Address", Contact.Address );
            command.Parameters.AddWithValue("@CountryID", Contact.CountryID );

            try
            {
                connection.Open();
                int RowAffectd = command.ExecuteNonQuery();

                if (RowAffectd > 0)
                {
                    Console.WriteLine("Record Inserted Seccussfuly");
                }
                else
                {
                    Console.WriteLine("Record Inserted Failed");
                }


            }
            catch(Exception ex)
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
                LastName = "Elkhattab",
                Email = "Whatever",
                Phone = "000000",
                Address = "fbs",
                CountryID = 1
            };
            AddNewContact(Contact);
        }
    }
}
