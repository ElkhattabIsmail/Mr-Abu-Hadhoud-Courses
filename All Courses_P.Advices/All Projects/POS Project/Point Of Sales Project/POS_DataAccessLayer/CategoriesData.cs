using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataAccessLayer
{
    public class CategoriesData
    {
        public static int AddNew(string CategoyName)
        {
            int newId = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewCategory", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoyName", CategoyName);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out newId))
                            return newId;

                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message);  } 
                }
            }

            return newId;
        }
        public static bool Update(int CategoryID, string CategoyName)
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateCategory", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);
                    command.Parameters.AddWithValue("@CategoyName", CategoyName);
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
        public static bool GetPersonBy(int CategoryID, ref string CategoyName)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetCategoryByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            CategoryID = (int)reader["CategoryID"];
                            CategoyName = reader["CategoyName"] != DBNull.Value ? (string)reader["CategoyName"] : string.Empty;


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
            return GenericData.GetGetAllTableRecords("SP_GetAllCategories");
        }
        static public bool Delete(int CategoryID)
        {
            return GenericData.Delete(CategoryID, "SP_DeleteCategoryByID", "@CategoryID");
        }
        static public bool IsExist(int CategoryID)
        {
            return GenericData.IsExistWith(1, "SP_IsCategoryExist", "@CategoryID");
        }

    }
}
