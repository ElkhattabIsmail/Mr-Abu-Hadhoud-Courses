using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_DataAccessLayer
{
    public class ClsPaymentsData
    {
        public static int AddNew(string PaymentMethod, DateTime TransactionDate, int SaleID)
        {
            int newId = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewPaymentMethod", connection))
                {
                    command.CommandType = CommandType.StoredProcedure; 
                    command.Parameters.AddWithValue("@PaymentMethod", !string.IsNullOrWhiteSpace(PaymentMethod) ? PaymentMethod : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                    command.Parameters.AddWithValue("@SaleID", SaleID);

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
        public static bool Update(int PaymentID, string PaymentMethod , DateTime TransactionDate, int SaleID)
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_UpdatePayment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                    command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                    command.Parameters.AddWithValue("@SaleID", SaleID);

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
        public static bool GetPersonBy(int PaymentID, ref string PaymentMethod,ref DateTime TransactionDate, ref int SaleID)
        {
            bool IsFound = false;
            
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPaymentByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PaymentID", PaymentID);
                    command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);

                    command.Parameters.AddWithValue("@TransactionDate", TransactionDate);

                    command.Parameters.AddWithValue("@SaleID", SaleID);


                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            IsFound = true;
                            PaymentID = (int)reader["PaymentID"];
                            PaymentMethod = reader["PaymentMethod"].ToString();
                            TransactionDate = (DateTime)reader["TransactionDate"];
                            SaleID = (int)reader["SaleID"];
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
            return GenericData.GetGetAllTableRecords("SP_GetAllPayments");
        }
        static public bool Delete(int PaymentID)
        {
            return GenericData.Delete(PaymentID, "SP_DeletePaymentByID", "@PaymentID");
        }
        static public bool IsExist(int PaymentID)
        {
            return GenericData.IsExistWith(PaymentID, "SP_IsPaymentExist", "@PaymentID");
        }

    }
}
