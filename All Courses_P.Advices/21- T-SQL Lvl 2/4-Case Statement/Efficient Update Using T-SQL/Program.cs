using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efficient_Update_Using_T_SQL
{
    internal class Program
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
        static void Main(string[] args)
        {
            Stopwatch StopWatch1 = new Stopwatch();
            StopWatch1.Start();


            if (!EfficientUpdateOnDB())
            {
                Console.WriteLine($"Update failed");
                return;
            }
            Console.WriteLine($"Time Consuming : {StopWatch1.ElapsedMilliseconds} ms");
            Console.ReadLine();
        }
    }
}
