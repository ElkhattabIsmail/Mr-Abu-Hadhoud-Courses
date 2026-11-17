using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataAccessLayer
{
    public class ClsPeopleData
    {
        public static int AddNewNewPerson(string FirstName, string LastName, string Phone, string Email, string Address)
        {
            int rowsAffected = -1;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_AddNewANewPerson", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@FirstName", FirstName));
                    command.Parameters.Add(new SqlParameter("@LastName", LastName));
                    command.Parameters.Add(new SqlParameter("@Email", Email));
                    command.Parameters.Add(new SqlParameter("@Phone", Phone));
                    command.Parameters.Add(new SqlParameter("@Address", Address));
                    

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                }
            }

            return rowsAffected ;
        }
        public static bool UpdatePerson(int PersonID, string FirstName, string LastName, string Phone, string Email, string Address)
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Phone", !string.IsNullOrWhiteSpace(Phone) ? Phone : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", !string.IsNullOrWhiteSpace(Email) ? Email : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Address", !string.IsNullOrWhiteSpace(Address) ? Address : (object)DBNull.Value);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                }
            }

            return RowsAffected > 0;
        }
        public static bool GetPersonBy(int PersonID, ref string FirstName, ref string LastName, ref string Phone, ref string Email, ref string Address)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPersonByID", connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            PersonID = (int)reader["PersonID"];
                            FirstName = (string)reader["FirstName"];
                            LastName = (string)reader["LastName"];
                            Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : string.Empty;
                            Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : string.Empty;
                            Address = reader["Address"] != DBNull.Value ? (string)reader["Address"] : string.Empty;

                        }
                        else
                        {
                            IsFound = false;
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                }
            }

            return IsFound;
        }
        static public DataTable GetPersonByGetAllPeopleFromDb()
        {
            return GenericData.GetGetAllTableRecords("dbo.SP_GetPersonByGetAllPeople");
        }
        static public bool Delete(int PersonID)
        {
            return GenericData.Delete(PersonID, "SP_DeletePersonWithID","@PersonID");
        }
        static public bool IsPersonIsExist(int PersonID)
        {
            return GenericData.IsExistWith( PersonID , "SP_IsPersonIsExist", "@PersonID");
        }

    }
}
