using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesDataAccessLayer;

namespace EmployeesBussinessLayer
{
    public class ClsEmployee
    {
        public string Name { get; set; }
        public string Departement { get; set; }
        public int Salary {  get; set; }
        public int PerformanceRating {  get; set; }

        private ClsEmployee (string Name, string Departement, int Salary, int PerformanceRating)
        {
            this.Name = Name;
            this.Departement = Departement;
            this.Salary = Salary;
            this.PerformanceRating = PerformanceRating;
        }
        public ClsEmployee()
        {
            this.Name = "";
            this.Departement = "";
            this.Salary = 0;
            this.PerformanceRating = 0;
        }
        public static DataTable GetAllEmployees()
        {
            return ClsEmployesData.GetAllEmployesFromDB();
        }
        public static bool EfficientUpdate()
        {
            return ClsEmployesData.EfficientUpdateOnDB();
        }
        public bool UpdateEmployee()
        {
            return ClsEmployesData.UpdateEmployeSalary(this.Name ,this.Departement ,this.Salary ,this.PerformanceRating);
        }
      
    }
}
