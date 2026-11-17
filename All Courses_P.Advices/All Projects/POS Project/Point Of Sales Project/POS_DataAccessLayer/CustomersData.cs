using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataAccessLayer
{
    public class CustomersData
    {
        public static int AddNew(int PersonID)
        {
            int newId = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", (PersonID == 0) ? DBNull.Value : (object)PersonID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newId = insertedID;
                        }

                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message);  } 
                }
            }

            return newId;
        }
        public static bool Update(int CustomerID, int PersonID)
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    command.Parameters.AddWithValue("@PersonID", (PersonID == 0) ? DBNull.Value : (object)PersonID);

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
        public static bool GetPersonBy(int CustomerID, ref int PersonID)
        {
            bool IsFound = false;
            string query = "select * from Customers  WHERE CustomerID=@CustomerID;";
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            CustomerID = (int)reader["CustomerID"];
                            PersonID = reader["PersonID"] != DBNull.Value ? (int)reader["PersonID"] : -1;


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
            return GenericData.GetGetAllTableRecords("SP_GetAllCustomers");
        }
        static public bool Delete(int CustomerID)
        {
            return GenericData.Delete(CustomerID, "SP_DeleteCustomerByID", "@CustomerID");
        }
        static public bool IsExist(int CustomerID)
        {
            return GenericData.IsExistWith( CustomerID, "SP_IsCustomerExist", "@CustomerID");
        }

    }
}
