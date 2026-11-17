
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GROUPEmployeesBYPerformanceCategory
{
    internal class Program
    {
        static string ConnectionString = @"Server=.;Database=C21_DB1;User Id=sa;Password=sa123456;";


        static DataTable GetAllEmployeesFromDB()
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


            int NumberOfHighPerformanceEmployees = 0;
            int NumberOfMedPerformanceEmployees = 0;
            int NumberOfLowPerformanceEmployees = 0;

            float HighPerformanceTotalSalary = 0;
            float MedPerformanceTotalSalary = 0;
            float LowPerformanceTotalSalary = 0;

            float Salary = 0;
            int PerformanceRating = 0;

            DataTable dtAllEmployees2 = GetAllEmployeesFromDB();

            foreach (DataRow EmployeeRow in dtAllEmployees2.Rows)
            {
                Salary = Convert.ToSingle(EmployeeRow["Salary"]);
                PerformanceRating = (int)(EmployeeRow["PerformanceRating"]);

                if (PerformanceRating >= 80)
                {
                    NumberOfHighPerformanceEmployees++;
                    HighPerformanceTotalSalary += Salary;
                }
                else if (PerformanceRating >= 60)
                {
                    NumberOfMedPerformanceEmployees++;
                    MedPerformanceTotalSalary += Salary;
                }
                else
                {
                    NumberOfLowPerformanceEmployees++;
                    LowPerformanceTotalSalary += Salary;
                }
            }
            Console.WriteLine($"Performance  Category : High -> Number Of Employees : {NumberOfHighPerformanceEmployees} ," +
                $" AverageSalary : {HighPerformanceTotalSalary/ NumberOfHighPerformanceEmployees}");
            Console.WriteLine($"Performance  Category : Med -> Number Of Employees : {NumberOfMedPerformanceEmployees} ," +
                $" AverageSalary : {MedPerformanceTotalSalary / NumberOfHighPerformanceEmployees}");

            if (NumberOfLowPerformanceEmployees != 0)
            {
                Console.WriteLine($"Performance  Category : Med -> Number Of Employees : {NumberOfLowPerformanceEmployees} ," +
                $" AverageSalary : {LowPerformanceTotalSalary / NumberOfLowPerformanceEmployees}");
            }
            Console.WriteLine($"Time : {watch.ElapsedMilliseconds} ms");
            Console.ReadLine();
        }
    }

}




