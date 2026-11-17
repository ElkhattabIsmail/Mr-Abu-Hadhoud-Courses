using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;


class Program
{
    public static void CheckPersonExists(int PersonID)
    {
        try
        {
            string connectionString = "Server=.;Database=DVLD;User Id=sa;Password=sa123456;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SP_CheckPersonExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                    SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnParameter);
                    command.ExecuteNonQuery();

                    bool personExists = (int)returnParameter.Value == 1;

                    Console.WriteLine($" Person Exist   {personExists}");

                    connection.Close();

                }
            }

        }
        catch (Exception ex)
        {

            Console.WriteLine($" Person doesn't Exist   {ex.Message}");
        }

    }

    static void Main()
    {

        CheckPersonExists(4000);
        Console.ReadKey();

        const string connectionString = "Server=.;Database=DVLD;User Id=sa;Password=sa123456;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
            {
                command.CommandType = CommandType.StoredProcedure;



                // Add parameters
                command.Parameters.AddWithValue("@FirstName", "John");
                command.Parameters.AddWithValue("@LastName", "Doe");
                command.Parameters.AddWithValue("@Email", "john.doe@example.com");

                command.Parameters.AddWithValue("@NationalNo", "No007");

                command.Parameters.AddWithValue("@Gender", 1);
                command.Parameters.AddWithValue("@Phone", "0000000012");
                command.Parameters.AddWithValue("@Address", "No Address");
       
                command.Parameters.AddWithValue("@NationalityCountryID", 1);

           

                SqlParameter outputIdParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);


                // Execute
                connection.Open();
                command.ExecuteNonQuery();


                // Retrieve the ID of the new person
                int newPersonID = (int)command.Parameters["@NewPersonID"].Value;
                Console.WriteLine($"New Person ID: {newPersonID}");
            }
        }


    }
}
