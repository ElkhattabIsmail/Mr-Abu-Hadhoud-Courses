using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Code_Generator
{
    public class clsValidator
    {


        private static readonly string _ConnectionString;
        static clsValidator()
        {
            _ConnectionString = Properties.Settings.Default.ConnectionString ?? "Data Source=.;Initial Catalog=master;Integrated Security=True;";
        }


        public static bool CheckConnection()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(_ConnectionString))
                {
                    connection.Open();
                    return true;
                }

            }
            catch (Exception)

            {
                return false;
            }


        }


    }
}
