using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Gen_DataAccess.GlobalClasses
{
    public class clsGlobal
    {
        public static string ConnectionString;

        public static string DatabaseName { get; set; }

        public static clsTable CurrentTable = new clsTable();


        public static void SetConnectionString(string StoredConnectionString)
        {
            ConnectionString = StoredConnectionString;
        }

        static clsGlobal()
        {

        }
    }
}
