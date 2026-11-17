using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_DataAccessLayer;

namespace POS_DataAccessLayer
{
    public class GenericData
    {
        static public DataTable GetGetAllTableRecords(string StoreProcedureName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(StoreProcedureName , connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        SqlDataReader Reader = command.ExecuteReader();
                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message ); }
                }
            }
            return dt;
        }
        static public bool Delete<T>(T Parameter , string StoreProcedureName, string withValue)
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(StoreProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(withValue, Parameter);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
                }
            }

            return RowsAffected > 0;
        }
        static public bool IsExistWith<T>( T Value , string StoreProcedureName , string WithValue)
        {
            if (string.IsNullOrEmpty(WithValue))
            {
                throw new ArgumentException("Parameter name cannot be null or empty.", nameof(WithValue));
            }
            using (SqlConnection connection = new SqlConnection(ClsConnectingStringData.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(StoreProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(WithValue, Value);
                    try
                    {
                        connection.Open();
                        SqlParameter returnValue = new SqlParameter();
                        returnValue.ParameterName = "@ReturnValue";
                        returnValue.Direction = System.Data.ParameterDirection.ReturnValue;
                        command.Parameters.Add(returnValue);

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        return Convert.ToInt32(returnValue.Value) == 1;
                    }
                    catch (Exception ex)
                    {
                        // Log the exception Later
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return false;
        }

    }
}
