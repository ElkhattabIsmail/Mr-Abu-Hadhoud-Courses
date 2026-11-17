using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Gen_DataAccess.GlobalClasses
{
    public class clsUtil
    {
        public static List<string> GetAllDatabasesNames()
        {
            List<string> DBlist = new List<string>();

            try
            {


                using (SqlConnection connection = new SqlConnection(clsGlobal.ConnectionString))
                {
                    string query = @"SELECT Name FROM sys.databases Where database_id > 4
	                                    Order By Name ASC;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DBlist.Add((string)reader["Name"]);
                            }
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }


            return DBlist;
        }


        public static List<string> GetAllTablesByDatabaseName(string DatabaseName)
        {
            List<string> TablesNames = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsGlobal.ConnectionString))
                {
                    string query = @"SELECT TABLE_NAME 
	                                FROM [{DatabaseName}].INFORMATION_SCHEMA.TABLES
                                	WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME <> 'sysdiagrams';";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DBName", DatabaseName);

                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TablesNames.Add((string)reader["TABLE_NAME"]);
                            }
                        }
                    }
                }

            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.Message);
            }


            return TablesNames;
        }



        public static List<clsColumn> GetAllTableColumnsForClass(string TableName)
        {

            clsColumn col = null;
            List<clsColumn> AllColumns = new List<clsColumn>();


            try
            {


                using (SqlConnection connection = new SqlConnection(clsGlobal.ConnectionString))
                {
                    string query = $@"Use {clsGlobal.DatabaseName};
            SELECT 
              c.COLUMN_NAME,
                CASE 
                    WHEN c.DATA_TYPE IN ('tinyint', 'smallint', 'int') THEN 'int'
                    WHEN c.DATA_TYPE = 'bigint' THEN 'long'
                    WHEN c.DATA_TYPE IN ('decimal', 'numeric', 'smallmoney', 'money') THEN 'decimal'
                    WHEN c.DATA_TYPE IN ('float', 'real') THEN 'double'
                    WHEN c.DATA_TYPE IN ('char', 'nchar', 'varchar', 'nvarchar', 'text', 'ntext') THEN 'string'
                    WHEN c.DATA_TYPE IN ('date', 'datetime', 'datetime2', 'smalldatetime', 'timestamp') THEN 'DateTime'
                    WHEN c.DATA_TYPE = 'time' THEN 'TimeSpan'
                    WHEN c.DATA_TYPE = 'bit' THEN 'bool'
                    WHEN c.DATA_TYPE IN ('binary', 'varbinary', 'image', 'rowversion') THEN 'byte[]'
                    WHEN c.DATA_TYPE = 'uniqueidentifier' THEN 'Guid'
                    WHEN c.DATA_TYPE = 'xml' THEN 'string'
                    ELSE 'object'
                END AS CSharpType,
               CASE 
		WHEN  c.IS_NULLABLE = 'YES' THEN 1
		ELSE 0
		END AS  IS_NULLABLE,
                CASE 
                    WHEN t.CONSTRAINT_TYPE = 'PRIMARY KEY' THEN 1
                    ELSE 0
                END AS IsPrimaryKey
    FROM INFORMATION_SCHEMA.COLUMNS c
    LEFT JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE k 
    ON c.TABLE_NAME = k.TABLE_NAME 
    AND c.COLUMN_NAME = k.COLUMN_NAME
    LEFT JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS t 
    ON k.CONSTRAINT_NAME = t.CONSTRAINT_NAME 
    AND t.CONSTRAINT_TYPE = 'PRIMARY KEY'

    WHERE c.TABLE_NAME = @TableName
ORDER BY  c.ORDINAL_POSITION, IsPrimaryKey desc,c.COLUMN_NAME;
";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TableName", TableName);

                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                col = new clsColumn((string)reader["COLUMN_NAME"],
                                                    (string)reader["CSharpType"],
                                                    Convert.ToBoolean(reader["IS_NULLABLE"]),
                                                    Convert.ToBoolean(reader["IsPrimaryKey"]));
                                AllColumns.Add(col);
                            }

                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }


            return AllColumns;

        }



        public static List<clsColumn> GetAllTableColumnsForProcedure(string TableName)
        {

            clsColumn col = null;
            List<clsColumn> AllColumns = new List<clsColumn>();


            try
            {


                using (SqlConnection connection = new SqlConnection(clsGlobal.ConnectionString))
                {
                    string query = $@"Use {clsGlobal.DatabaseName};
   

        SELECT 
            c.COLUMN_NAME,
            CASE 
                -- Handle varchar, nvarchar, char, nchar, binary, varbinary
                WHEN c.DATA_TYPE IN ('varchar', 'nvarchar', 'char', 'nchar', 'binary', 'varbinary') 
                THEN UPPER(c.DATA_TYPE) + '(' + CAST(c.CHARACTER_MAXIMUM_LENGTH AS VARCHAR) + ')'
        
                -- Handle decimal and numeric
                WHEN c.DATA_TYPE IN ('decimal', 'numeric') 
                THEN UPPER(c.DATA_TYPE) + '(' + CAST(c.NUMERIC_PRECISION AS VARCHAR) + ',' + CAST(c.NUMERIC_SCALE AS VARCHAR) + ')'
        
                -- Handle float and real
                WHEN c.DATA_TYPE IN ('float', 'real') 
                THEN  UPPER(c.DATA_TYPE) + '(' + CAST(c.NUMERIC_PRECISION AS VARCHAR) + ')'
        
                -- For other data types (e.g., int, datetime, etc.)
                ELSE UPPER(c.DATA_TYPE)
            END AS DATA_TYPE,
            CASE 
                WHEN c.IS_NULLABLE = 'YES' THEN 1
                ELSE 0
            END AS IS_NULLABLE,
            CASE 
                WHEN t.CONSTRAINT_TYPE = 'PRIMARY KEY' THEN 1
                ELSE 0
            END AS IsPrimaryKey
        FROM INFORMATION_SCHEMA.COLUMNS c
        LEFT JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE k 
            ON c.TABLE_NAME = k.TABLE_NAME 
            AND c.COLUMN_NAME = k.COLUMN_NAME
        LEFT JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS t 
            ON k.CONSTRAINT_NAME = t.CONSTRAINT_NAME 
            AND t.CONSTRAINT_TYPE = 'PRIMARY KEY'
        WHERE c.TABLE_NAME = @TableName
        ORDER BY  c.ORDINAL_POSITION,IsPrimaryKey DESC, c.COLUMN_NAME;
        ";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TableName", TableName);

                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                col = new clsColumn((string)reader["COLUMN_NAME"],
                                                    (string)reader["DATA_TYPE"],
                                                    Convert.ToBoolean(reader["IS_NULLABLE"]),
                                                    Convert.ToBoolean(reader["IsPrimaryKey"]));
                                AllColumns.Add(col);
                            }

                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }


            return AllColumns;

        }
    }
}
