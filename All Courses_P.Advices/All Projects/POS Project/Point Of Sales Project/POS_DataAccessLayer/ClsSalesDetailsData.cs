using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataAccessLayer
{
    public class ClsSalesDetailsData
    {
        public static int AddNew(int CustomerID, int FK_ProductID, int FK_UserID, int PaimentMethodID,
            int ProductQuantity, DateTime SaleDate)
        {
            int newId = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewSale", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID", (CustomerID == 0) ? DBNull.Value : (object)CustomerID);
                    command.Parameters.AddWithValue("@FK_ProductID", (FK_ProductID == 0) ? DBNull.Value : (object)FK_ProductID);
                    command.Parameters.AddWithValue("@FK_UserID", (FK_UserID == 0) ? DBNull.Value : (object)FK_UserID);
                    command.Parameters.AddWithValue("@PaimentMethodID", (PaimentMethodID == 0) ? DBNull.Value : (object)PaimentMethodID);
                    command.Parameters.AddWithValue("@ProductQuantity", ProductQuantity);
                    command.Parameters.AddWithValue("@SaleDate", SaleDate);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out newId))
                            return newId;

                    }
                    catch (Exception ex) {Console.WriteLine(ex.Message); }
                }
            }

            return newId;
        }
        public static bool Update(int SaleID, int CustomerID, int FK_ProductID, int FK_UserID, int PaimentMethodID, int ProductQuantity, DateTime SaleDate)
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateSale", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SaleID", SaleID);
                    command.Parameters.AddWithValue("@CustomerID", (CustomerID == 0) ? DBNull.Value : (object)CustomerID);
                    command.Parameters.AddWithValue("@FK_ProductID", (FK_ProductID == 0) ? DBNull.Value : (object)FK_ProductID);
                    command.Parameters.AddWithValue("@FK_UserID", (FK_UserID == 0) ? DBNull.Value : (object)FK_UserID);
                    command.Parameters.AddWithValue("@PaimentMethodID", (PaimentMethodID == 0) ? DBNull.Value : (object)PaimentMethodID);
                    command.Parameters.AddWithValue("@ProductQuantity", ProductQuantity);
                    command.Parameters.AddWithValue("@SaleDate", SaleDate);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex) {Console.WriteLine(ex.Message); }
                }
            }
            return RowsAffected > 0;
        }
        public static bool GetPersonBy(int SaleID, ref int CustomerID, ref int FK_ProductID, ref int FK_UserID, ref int PaimentMethodID, ref int ProductQuantity, ref DateTime SaleDate)
        {
            bool IsFound = false;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetSaleByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SaleID", SaleID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            SaleID = (int)reader["SaleID"];
                            CustomerID = (int)reader["CustomerID"];
                            FK_ProductID = (int)reader["FK_ProductID"] ;
                            FK_UserID = (int)reader["FK_UserID"];
                            PaimentMethodID = (int)reader["PaimentMethodID"];
                            ProductQuantity = (int)reader["ProductQuantity"];
                            SaleDate = (DateTime)reader["SaleDate"];
                        }
                        else
                        {
                            IsFound = false;
                        }
                    }
                    catch (Exception ex) {Console.WriteLine(ex.Message); }
                }
            }

            return IsFound;
        }
        static public DataTable GetAll()
        {
            return GenericData.GetGetAllTableRecords("SP_GetAllSaleDetails");
        }
        static public bool Delete(int SaleID)
        {
            return GenericData.Delete(SaleID, "SP_DeleteSaleByID", "@SaleID");
        }
        static public bool IsExist(int SaleID)
        {
            return GenericData.IsExistWith( SaleID, "SP_IsSaleExist", "@SaleID");
        }

    }
}
