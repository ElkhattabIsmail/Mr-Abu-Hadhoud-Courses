using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataAccessLayer
{
    public class ClsUsersData
    {
        public static int AddNew(string UserName, string Password, int Permission, bool IsActive, int PersonID)
        {
            int newUserID = -1;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // AddNew input parameters
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Permission", Permission);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

                    try
                    {
                        connection.Open();

                        // Execute the stored procedure and retrieve the new UserID
                        object result = command.ExecuteScalar();

                        // Check if the result is not null and convert it to an integer
                        if (result != null && int.TryParse(result.ToString(), out newUserID))
                            return newUserID;
                    }
                    catch (Exception ex)
                    {
                        // Log the exception
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return newUserID;
        }
        public static bool Update(int UserID, string UserName, string Password, int Permission, bool IsActive, int PersonID)
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Permission", Permission);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message);  } 
                }
            }

            return RowsAffected > 0;
        }
        public static bool GetUserByID(int UserID, ref string UserName, ref string Password, ref int Permission,
            ref bool IsActive, ref int PersonID)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByID", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserID", UserID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            UserName = (string)reader["UserName"];
                            Password = (string)reader["Password"];
                            Permission = (int)reader["Permission"];
                            IsActive = (bool)reader["IsActive"];
                            PersonID = (int)reader["PersonID"];


                        }
                        else
                        {
                            IsFound = false;
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message);  } 
                }
            }

            return IsFound;
        }
        static public DataTable GetAll()
        {
            return GenericData.GetGetAllTableRecords("SP_GetAllUsers");
        }
        static public bool Delete(int UserID)
        {
            return GenericData.Delete(UserID, "SP_DeleteUserByID", "@UserID");
        }
        static public bool Exist(int UserID)
        {
            return GenericData.IsExistWith( UserID, "SP_IsUserExist", "@UserID");
        }

    }
}

class Program
{
    static void Main()
    {
        // Define connection string (replace with your own)
        string connectionString = "YourConnectionString";

        // Create SQL query or stored procedure that includes an output parameter
        string sqlQuery = "EXEC YourStoredProcedure @InputParameter, @ReturnValue OUTPUT";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                // AddNew an input parameter (if needed)
                SqlParameter inputParameter = new SqlParameter("@InputParameter", SqlDbType.Int);
                inputParameter.Value = 123; // Example value
                command.Parameters.Add(inputParameter);

                // AddNew the output parameter
                SqlParameter outputParameter = new SqlParameter
                {
                    ParameterName = "@ReturnValue",
                    SqlDbType = SqlDbType.Int, // Set the appropriate SQL type
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputParameter);

                // Open the connection
                connection.Open();

                // Execute the command
                command.ExecuteNonQuery();

                // Retrieve the value of the output parameter
                int returnValue = (int)outputParameter.Value;
                Console.WriteLine($"The output value is: {returnValue}");
            }
        }
    }
}
