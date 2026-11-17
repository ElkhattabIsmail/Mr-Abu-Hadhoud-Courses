using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; // sql Data providers

namespace ConsoleApp1
{
    internal class Program
    {
        // . = local host
        // global string
        static string ConnectionString = "server =.;Database=ContactsDB;User Id =sa;Password=sa123456 ;";

        static void PrintAllContacts()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);  // connnect data base
            string qwery = "\r\nselect * from Contacts\r\nwhere ContactID = 5;";  // get your qwery in a string
            SqlCommand Command = new SqlCommand(qwery, connection);  // excute the qwery by using sql (command) 
            // take the command and excute on this database (connection);


            // Using try catch is neccessery with db

            try
            {
                connection.Open(); // open a part of connection with data base
                SqlDataReader reader = Command.ExecuteReader();  // return data readOnly and forward data

                while (reader.Read ())
                {
                    int ContactID = (int)reader["ContactID"]; // 0 1 2 3 4 5
                    string firstName = reader["FirstName"].ToString ();
                    string lastName = reader["LastName"].ToString();
                    string email = reader["Email"].ToString();
                    string phone = reader["Phone"].ToString();
                    string address = reader["Address"].ToString();
                    int CountryID = (int)reader["countryID"];

                    Console.WriteLine($"ContactID = {ContactID} ");
                    Console.WriteLine($"FirstName = {firstName} ");
                    Console.WriteLine($"LastName = {lastName} ");
                    Console.WriteLine($"Email = {email} ");
                    Console.WriteLine($"Phone = {phone} ");
                    Console.WriteLine($"Address = {address} ");
                    Console.WriteLine($"countryID = {CountryID} ");
                    Console.WriteLine();

                   
                }
                reader.Close(); // Is vary important
                connection.Close(); // Very important too . Connection with DB is very Heavy (  connnection Pool )
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void GetCountryNameFromDB(string Country_ID)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);  // connnect data base
            string qwery = $"\r\nSELECT  Countries.CountryName\r\nFROM     Contacts INNER JOIN\r\n " +
                "              Countries ON Contacts.CountryID = Countries.CountryID\r\nWHERE " +
                "  (Contacts.ContactID = @Country_ID)";  // get your qwery in a string
            SqlCommand Command = new SqlCommand(qwery, connection);  // excute the qwery by using sql (command) 
            // take the command and excute on this database (connection);


            // Parameterized Qwery
            Command.Parameters.AddWithValue("@Country_ID", Country_ID);

            // Using try catch is neccessery with db

            try
            {
                connection.Open(); // open a part of connection with data base
                SqlDataReader reader = Command.ExecuteReader();  // return data readOnly and forward data

                while (reader.Read())
                {
                    string CountryName = reader["countryName"].ToString();
                    Console.WriteLine($"country name  = {CountryName} ");

                }
                reader.Close(); // Is vary important
                connection.Close(); // Very important too . Connection with DB is very Heavy (  connnection Pool )
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
       
        static void Main(string[] args)
        {
            //PrintAllContacts();
            string Choice = "";
            Console.Write("Enter Country Id between 1 and 5 : ");
            Choice = Console.ReadLine();

            GetCountryNameFromDB(Choice);
        }
    }
}
