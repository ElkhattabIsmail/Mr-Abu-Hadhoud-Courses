using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDataAccessLayer
{
    public class ClsDataAccessSettings
    {
        public static string ConnectionString = "Server=.;Database=C21_DB1;User Id=sa;Password=sa123456;";
        //New Version of getting the ConnectionString using app.config 
        //public static string Connect = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
    }
}
