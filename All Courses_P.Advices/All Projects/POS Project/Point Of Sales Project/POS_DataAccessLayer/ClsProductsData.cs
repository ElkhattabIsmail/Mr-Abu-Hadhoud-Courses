using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace POS_DataAccessLayer
{
    public class ClsProductsData
    {
        public static int AddNew(string ProductName, decimal Price, int FK_CategoryID, string Description,
            int ProductQuantityInStock,string ImageUrl,DateTime  DateAdded , DateTime LastUpdatedDate)
        {
            int newId = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductName", ProductName);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@FK_CategoryID", (FK_CategoryID == 0) ? DBNull.Value : (object)FK_CategoryID);
                    command.Parameters.AddWithValue("@Description", !string.IsNullOrWhiteSpace(Description) ? Description : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ProductQuantityInStock", ProductQuantityInStock);
                    command.Parameters.AddWithValue("@ImageUrl", ImageUrl);
                    command.Parameters.AddWithValue("@DateAdded", DateAdded);
                    command.Parameters.AddWithValue("@LastUpdated", LastUpdatedDate);
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
        public static bool Update(int ProductID, string ProductName, decimal Price, int FK_CategoryID, string Description,
            int ProductQuantityInStock, string ImageUrl, DateTime DateAdded, DateTime LastUpdatedDate)
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", ProductID);
                    command.Parameters.AddWithValue("@ProductName", ProductName);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@FK_CategoryID", (FK_CategoryID == 0) ? DBNull.Value : (object)FK_CategoryID);
                    command.Parameters.AddWithValue("@Description", !string.IsNullOrWhiteSpace(Description) ? Description : (object)DBNull.Value);

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
        public static bool GetProductBYID(int ProductID,ref string ProductName, ref decimal Price, ref int FK_CategoryID, ref string Description,
            ref int ProductQuantityInStock, ref string ImageUrl, ref DateTime DateAdded, ref DateTime LastUpdatedDate)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetProductByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", ProductID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            ProductID = (int)reader["ProductID"];
                            ProductName = (string)reader["ProductName"];
                            Price = (decimal)reader["Price"];
                            FK_CategoryID = reader["FK_CategoryID"] != DBNull.Value ? (int)reader["FK_CategoryID"] : -1;
                            Description = reader["Description"] != DBNull.Value ? (string)reader["Description"] : string.Empty;


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
            return GenericData.GetGetAllTableRecords("SP_GetAllProducts");
        }
        static public bool Delete(int ProductID)
        {
            return GenericData.Delete(ProductID, "SP_DeleteProductByID", "@ProductID");
        }
        static public bool IsExist(int ProductID)
        {
            return GenericData.IsExistWith(1, "SP_IsProductExist", "@ProductID");
        }

    }
}
