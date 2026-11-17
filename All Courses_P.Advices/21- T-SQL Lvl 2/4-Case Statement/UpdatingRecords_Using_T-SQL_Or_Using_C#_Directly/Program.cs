using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesBussinessLayer;

namespace UpdatingRecords_Using_T_SQL_Or_Using_C__Directly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesTable = ClsEmployee.GetAllEmployees();
            ClsEmployee Emp = new ClsEmployee();
            Stopwatch StopWatch1 = new Stopwatch();
            StopWatch1.Start();

            float Salary = 0;
            int PerformanceRating = 0;

            foreach (DataRow Row in EmployeesTable.Rows)
            {
                PerformanceRating = (int)Row["PerformanceRating"];
                Salary = Convert.ToSingle(Row["Salary"]);

                if (PerformanceRating > 90)
                {
                    Salary *= 1.15f;
                }
                else if (PerformanceRating >= 75 && PerformanceRating <= 90)
                {
                    Salary *= 1.10f;
                }
                else
                {
                    Salary *= 1.05f;
                }
                Emp.Name = Row["Name"].ToString();
                Emp.Departement = Row["Department"].ToString();
                Emp.Salary = (int)Salary;
                Emp.PerformanceRating = PerformanceRating;

                if (!Emp.UpdateEmployee())
                    break;
            }
            StopWatch1.Stop();
            Console.WriteLine($"Time Consuming Using C#: {StopWatch1.ElapsedMilliseconds} ms");



            // T-SQL
            Stopwatch StopWatch2 = new Stopwatch();
            StopWatch2.Start();

            if (!ClsEmployee.EfficientUpdate())
            {
                Console.WriteLine($"Update failed");
                return;
            }
            StopWatch2.Stop();

            Console.WriteLine($"Time Consuming Using T-SQL: {StopWatch2.ElapsedMilliseconds} ms");
         
        }
    }
}