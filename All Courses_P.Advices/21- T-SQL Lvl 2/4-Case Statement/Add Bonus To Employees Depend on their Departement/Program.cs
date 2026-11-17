
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Bonus_To_Employees_Depend_on_their_Departement
{
    internal class Program
    {
        static string ConnectionString = @"Server=.;Database=C21_DB1;User Id=sa;Password=sa123456;";
        public static bool UpdateEmployeeBonus(decimal Bonus, string Name)
        {
            int rowsAffected = 0;
            bool isUpdated = false;
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();
                string Query = @"UPDATE Employees2 
                             SET Bonus = @Bonus 
                             WHERE Name = @Name";
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@Bonus", Bonus);
                    Command.Parameters.AddWithValue("@Name", Name);
                    rowsAffected = Command.ExecuteNonQuery();
                    isUpdated = Command.ExecuteNonQuery() > 0;
                }
            }
            return isUpdated;
        }


        static DataTable GetAllEmployees2()
        {
            DataTable employeesTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string Query = "SELECT * FROM Employees2;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                        employeesTable.Load(reader);
                }
            }
            return employeesTable;
        }
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            float Salary = 0;
            int PerformanceRating = 0;
            decimal Bonus = 0;
            string DepartmentName = "";

            DataTable dtAllEmployees2 = GetAllEmployees2();

            foreach (DataRow EmployeeRow in dtAllEmployees2.Rows)
            {
                Salary = Convert.ToSingle(EmployeeRow["Salary"]);
                PerformanceRating = (int)EmployeeRow["PerformanceRating"];
                DepartmentName = (string)EmployeeRow["Department"];

                if (DepartmentName == "Sales")
                {
                    switch (PerformanceRating)
                    {
                        case int rating when rating > 90:
                            Bonus = (decimal)Salary * 0.15m;
                            break;
                        case int rating when rating < 90 && rating > 75:
                            Bonus = (decimal)Salary * 0.10m;
                            break;
                        case int rating when rating < 74 && rating > 50:
                            Bonus = (decimal)Salary * 0.05m;
                            break;
                        default:
                            Bonus = 0;
                            break;
                    }
                }
                else if (DepartmentName == "HR")
                {
                    switch (PerformanceRating)
                    {
                        case int rating when rating > 90:
                            Bonus = (decimal)Salary * 0.10m;
                            break;
                        case int rating when rating < 90 && rating > 75:
                            Bonus = (decimal)Salary * 0.08m;
                            break;
                        case int rating when rating < 74 && rating > 50:
                            Bonus = (decimal)Salary * 0.04m;
                            break;
                        default:
                            Bonus = 0;
                            break;
                    }
                }
                else
                {
                    switch (PerformanceRating)
                    {
                        case int rating when rating > 90:
                            Bonus = (decimal)Salary * 0.08m;
                            break;
                        case int rating when rating < 90 && rating > 75:
                            Bonus = (decimal)Salary * 0.06m; // Fixed incorrect format (01.06F)
                            break;
                        case int rating when rating < 74 && rating > 50:
                            Bonus = (decimal)Salary * 0.03m;
                            break;
                        default:
                            Bonus = 0;
                            break;
                    }
                }

                UpdateEmployeeBonus(Bonus, (string)EmployeeRow["Name"]);
            }


            Console.WriteLine($"Time : {watch.ElapsedMilliseconds} ms");
            Console.ReadLine();
        }
    }

}



 
