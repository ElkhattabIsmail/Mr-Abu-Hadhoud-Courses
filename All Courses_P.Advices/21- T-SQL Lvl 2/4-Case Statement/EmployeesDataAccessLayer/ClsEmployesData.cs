using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;

namespace EmployeesDataAccessLayer
{
    public class ClsEmployesData
    {
        public static DataTable GetAllEmployesFromDB()
        {

            DataTable dt = new DataTable();
            string query = "select * from Employees2 order by Salary";

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return dt;
        }
        public static bool EfficientUpdateOnDB()
        {
            string query = @"UPDATE Employees2
                            SET Salary = 
                            CASE 
                             WHEN PerformanceRating > 90 THEN Salary * 1.15
                             WHEN PerformanceRating BETWEEN 75 AND 90 THEN Salary * 1.10
		                     WHEN PerformanceRating BETWEEN 50 AND 74 THEN Salary * 1.05
                             ELSE Salary
                             END;";

            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }
            return (rowsAffected > 0);
        }
        public static bool UpdateEmployeSalary(string Name , string Departement ,int Salary,int PerformanceRating)
        {
            string query = @"
                    Use C21_DB1;
                    UPDATE Employees2 
                    SET Salary = @Salary WHERE Name = @Name";

            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Salary", Salary);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }          
            return (rowsAffected > 0);
        }
      
    }
}
