using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Gen_DataAccess.GlobalClasses;

namespace CRUD_Gen_DataAccess
{
    public class clsDataAccessGenerator
    {
        private static StringBuilder _sbDataAccess = new StringBuilder();
        private static List<clsColumn> _PrimaryKeyCols = null;

        static clsDataAccessGenerator()
        {

        }


        public static void SetDataAccessGeneratorSettings(string TableName)
        {

            _sbDataAccess.Clear();
            clsGlobal.CurrentTable.ClassColumns = clsUtil.GetAllTableColumnsForClass(TableName);


            // Get primary key columns  
            _PrimaryKeyCols = clsGlobal.CurrentTable.ClassColumns.Where(c => c.IsPrimaryKey).ToList();

        }




        public static string GetDataAccessGeneratedCode()
        {
            _GenerateDataAccess();

            return _sbDataAccess.ToString();
        }


        public static string GetDataAccessGeneratedCodeAsync()
        {
            _GenerateDataAccessAsync();

            return _sbDataAccess.ToString();
        }

        private static void _GenerateDataAccess()
        {

            _GenerateUsingHeader();
            _GenerateNamespace();
            _GenerateClassHeader();
            _GenerateStaticConstructor();
            _GenerateGetObjectMethods();
            _GenerateAddNewObject();
            _GenerateUpdateObject();
            _GenerateDeleteObject();
            _GenerateIsExistsMethods();
            _GenerateGetAllRecords();


            _sbDataAccess.Append($@"{Environment.NewLine}     }}"); // closing class
            _sbDataAccess.Append($@"{Environment.NewLine}   }}"); // clsing namespace
        }

        private static void _GenerateDataAccessAsync()
        {

            _GenerateUsingHeader();
            _GenerateNamespace();
            _GenerateClassHeader();
            _GenerateStaticConstructor();
            _GenerateGetObjectMethods();
            _GenerateAddNewObjectAsync();
            _GenerateUpdateObjectAsync();
            _GenerateDeleteObjectAsync();
            _GenerateIsExistsMethodsAsync();
            _GenerateGetAllRecordsAsync();


            _sbDataAccess.Append($@"{Environment.NewLine}     }}"); // closing class
            _sbDataAccess.Append($@"{Environment.NewLine}   }}"); // clsing namespace
        }

        static string _GetMethodParametersList(bool PrimaryKey, bool WithDatatype, string Prefix = "")
        {
            string Params = "(";
            byte counter = 0;

            if (PrimaryKey)
                foreach (var col in _PrimaryKeyCols)
                {
                    if (counter >= 3)
                    {
                        Params += "\r\n  ";
                        counter = 0;
                    }
                    counter++;

                    if (!WithDatatype)
                    {
                        Params += $@"{Prefix}{col.ColumnName}, ";
                        continue;
                    }

                    Params += $@"{Prefix}{col.ColumnType} {col.ColumnName}, ";

                }



            foreach (var col in clsGlobal.CurrentTable.ClassColumns)
            {
                counter++;
                if (counter >= 3)
                {
                    Params += "\r\n  ";
                    counter = 0;
                }
                if (!col.IsPrimaryKey)
                {

                    if (WithDatatype)
                    {
                        Params += $@"{Prefix}{GetColumnTypeString(col.ColumnType, col.IsNullable)} {col.ColumnName}, ";
                        continue;
                    }

                    Params += $@"{Prefix}{col.ColumnName}, ";


                }

            }


            return Params.Substring(0, Params.Length - 2) + ")";

        }


        private static void _GenerateUsingHeader()
        {
            _sbDataAccess.Append($@"using System;{Environment.NewLine}");
            _sbDataAccess.Append($@"using System.Collections.Generic;{Environment.NewLine}");
            _sbDataAccess.Append($@"using System.Data;{Environment.NewLine}");
            _sbDataAccess.Append($@"using System.Threading.Tasks;{Environment.NewLine}");
            _sbDataAccess.Append($@"using System.Data.SqlClient;{Environment.NewLine + "\n\n"}");
        }


        private static void _GenerateNamespace()
        {
            _sbDataAccess.Append($@"namespace {clsGlobal.DatabaseName}_DataAccess   {Environment.NewLine}{{ {Environment.NewLine + "\n\n"}");
        }




        private static void _GenerateClassHeader()
        {

            _sbDataAccess.Append($@"{Environment.NewLine} public class {clsGlobal.CurrentTable.TableDataAccessClassName} {Environment.NewLine}  {{");

        }


        private static void _GenerateStaticConstructor()
        {
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     static {clsGlobal.CurrentTable.TableDataAccessClassName}(){{}} {"\n\n\r"}");
        }


        private static void _GenerateGetObjectMethods()
        {
            if (_PrimaryKeyCols.Count > 0)
                foreach (var col in _PrimaryKeyCols)
                {

                    _GenerateGetObject(col);
                }



            else
            {
                clsColumn col = clsGlobal.CurrentTable.ClassColumns.FirstOrDefault();
                _GenerateGetObject(col);
            }

        }

        private static void _GenerateGetObject(clsColumn col)
        {
            _sbDataAccess.Append($@"{Environment.NewLine + "\n\n"} public static bool Get{clsGlobal.CurrentTable.TableSingularName}By{col.ColumnName}"); // Table Singular name


            // replacing  (for example 'ref int PersonID') to 'int PersonID' because I have it already
            _sbDataAccess.Append($@"{_GetMethodParametersList(true, true, "ref ")
                .Replace($@"ref {col.ColumnType} {col.ColumnName}, ", $"{col.ColumnType} {col.ColumnName}, ")} {Environment.NewLine + "\n"}  {{");

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    bool IsFound = false; {Environment.NewLine + "\n"}");

            _sbDataAccess.Append(_GetTryCode());
            _sbDataAccess.Append(_GetSqlConntionCode());


            _sbDataAccess.Append(
               "\r  " + _GetSqlCommandCode().Replace("\"SP\"", $@"""{clsGlobal.CurrentTable.TableName}_Get{clsGlobal.CurrentTable.TableSingularName}By{col.ColumnName}""")); // Table Singular name // replceing "SP" From _GetSqlCommand With Actual Procedure name (TableName_Operation_ByColumnName);
            _sbDataAccess.Append(_GetParamsForSqlCommand(col));




            _sbDataAccess.Append(_GetSqlDataReader().Replace("action", "ExecuteReader()"));
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}"); //;
            _sbDataAccess.Append($@"        if(reader.Read())   {Environment.NewLine}        {{");
            _sbDataAccess.Append(_AssignValuesToMethodParameters(col));
            _sbDataAccess.Append("\r\n\r\n       IsFound = true;\n    }");
            _sbDataAccess.Append("\r\n     }"); // colsing using command
            _sbDataAccess.Append("\r\n     }\n\n   } \n\n   }"); // colsing using connection

            _sbDataAccess.Append(_GetCatchCode() + "\n   }");

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     return IsFound;{Environment.NewLine + "\n"}   }}");



        }



        private static void _GenerateAddNewObjectAsync()
        {
            _sbDataAccess.Append($@"{"\n\n" + "\n"}    public static async Task<int> AddNew{clsGlobal.CurrentTable.TableSingularName}Async{_GetMethodParametersList(true, true)}"); // Table Singular Name
            _sbDataAccess.Append($@"{Environment.NewLine}   {{");
            _sbDataAccess.Append($@"{Environment.NewLine}   {_GetTryCode()}");
            _sbDataAccess.Append($@"{"\n\n "}   {_GetSqlConntionCode()}");
            _sbDataAccess.Append($@"{"\n\n "}     {_GetSqlCommandCode()
                .Replace("connection.Open()", "await connection.OpenAsync()")
                .Replace("SP", $"{clsGlobal.CurrentTable.TableName}_InsertNew{clsGlobal.CurrentTable.TableSingularName}")}"); // Table Name , Table Singular Name


            _sbDataAccess.Append($@"{_GetParamsForSqlCommand(null)}");

            clsColumn column = _PrimaryKeyCols.FirstOrDefault() ?? clsGlobal.CurrentTable.ClassColumns.FirstOrDefault();

            _sbDataAccess.Append(_GenerateSqlParam("outputIdParam", $"New{column.ColumnName}", column.ColumnType));




            _sbDataAccess.Append($@"{Environment.NewLine}         await cmd.ExecuteNonQueryAsync();");

            _sbDataAccess.Append($@"{Environment.NewLine}        {column.ColumnType} new{column.ColumnName} = ({column.ColumnType})cmd.Parameters[""@New{column.ColumnName}""].Value;");

            _sbDataAccess.Append($@"{Environment.NewLine}        return new{column.ColumnName};");
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     }}"); // Closing Sql Command

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}");// Closing sql Connection

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}   }}"); // Closing Try 

            _sbDataAccess.Append(_GetCatchCode().Replace("IsFound = false;", "return 0;"));

            _sbDataAccess.Append($"{Environment.NewLine}   }}");

            _sbDataAccess.Append($@"{Environment.NewLine}   }}");


        }

        private static void _GenerateAddNewObject()
        {
            _sbDataAccess.Append($@"{"\n\n" + "\n"}    public static int AddNew{clsGlobal.CurrentTable.TableSingularName}{_GetMethodParametersList(true, true)}"); // Table Singular Name
            _sbDataAccess.Append($@"{Environment.NewLine}   {{");
            _sbDataAccess.Append($@"{Environment.NewLine}   {_GetTryCode()}");
            _sbDataAccess.Append($@"{"\n\n "}   {_GetSqlConntionCode()}");
            _sbDataAccess.Append($@"{"\n\n "}     {_GetSqlCommandCode()
                .Replace("SP", $"{clsGlobal.CurrentTable.TableName}_InsertNew{clsGlobal.CurrentTable.TableSingularName}")}"); // Table Name , Table Singular Name


            _sbDataAccess.Append($@"{_GetParamsForSqlCommand(null)}");

            clsColumn column = _PrimaryKeyCols.FirstOrDefault() ?? clsGlobal.CurrentTable.ClassColumns.FirstOrDefault();

            _sbDataAccess.Append(_GenerateSqlParam("outputIdParam", $"New{column.ColumnName}", column.ColumnType));




            _sbDataAccess.Append($@"{Environment.NewLine}          cmd.ExecuteNonQuery();");

            _sbDataAccess.Append($@"{Environment.NewLine}        {column.ColumnType} new{column.ColumnName} = ({column.ColumnType})cmd.Parameters[""@New{column.ColumnName}""].Value;");

            _sbDataAccess.Append($@"{Environment.NewLine}        return new{column.ColumnName};");
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     }}"); // Closing Sql Command

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}");// Closing sql Connection

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}   }}"); // Closing Try 

            _sbDataAccess.Append(_GetCatchCode().Replace("IsFound = false;", "return 0;"));

            _sbDataAccess.Append($"{Environment.NewLine}   }}");

            _sbDataAccess.Append($@"{Environment.NewLine}   }}");


        }



        private static void _GenerateUpdateObjectAsync()
        {
            _sbDataAccess.Append($@"{"\n\n" + "\n"}    public static async Task<bool> Update{clsGlobal.CurrentTable.TableSingularName}Async{_GetMethodParametersList(true, true)}"); // Table Singular Name
            _sbDataAccess.Append($@"{Environment.NewLine}   {{");


            _sbDataAccess.Append($@"{Environment.NewLine}        bool IsRowsAffected = false;");


            _sbDataAccess.Append($@"{Environment.NewLine}   {_GetTryCode()}");

            _sbDataAccess.Append($@"{"\n\n "}   {_GetSqlConntionCode()}");
            _sbDataAccess.Append($@"{"\n\n "}     {_GetSqlCommandCode()
                .Replace("connection.Open()", "await connection.OpenAsync()")
                .Replace("SP", $"{clsGlobal.CurrentTable.TableName}_Update{clsGlobal.CurrentTable.TableSingularName}")}"); // Table Name , Table Singular Name


            _sbDataAccess.Append($@"{_GetParamsForSqlCommand(null)}");




            _sbDataAccess.Append($@"{Environment.NewLine}         IsRowsAffected =  (await cmd.ExecuteNonQueryAsync() > 0);");

            _sbDataAccess.Append($@"{Environment.NewLine}       ");

            _sbDataAccess.Append($@"{Environment.NewLine}         ");
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     }}"); // Closing Sql Command

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}");// Closing sql Connection

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}   }}"); // Closing Try 

            _sbDataAccess.Append(_GetCatchCode().Replace("IsFound", "IsRowsAffected"));

            _sbDataAccess.Append($"{Environment.NewLine}   }}");
            _sbDataAccess.Append($"{Environment.NewLine}        return IsRowsAffected;");


            _sbDataAccess.Append($@"{Environment.NewLine}   }}");

        }

        private static void _GenerateUpdateObject()
        {
            _sbDataAccess.Append($@"{"\n\n" + "\n"}    public static bool Update{clsGlobal.CurrentTable.TableSingularName}{_GetMethodParametersList(true, true)}"); // Table Singular Name
            _sbDataAccess.Append($@"{Environment.NewLine}   {{");


            _sbDataAccess.Append($@"{Environment.NewLine}        bool IsRowsAffected = false;");


            _sbDataAccess.Append($@"{Environment.NewLine}   {_GetTryCode()}");

            _sbDataAccess.Append($@"{"\n\n "}   {_GetSqlConntionCode()}");
            _sbDataAccess.Append($@"{"\n\n "}     {_GetSqlCommandCode()

                .Replace("SP", $"{clsGlobal.CurrentTable.TableName}_Update{clsGlobal.CurrentTable.TableSingularName}")}"); // Table Name , Table Singular Name


            _sbDataAccess.Append($@"{_GetParamsForSqlCommand(null)}");




            _sbDataAccess.Append($@"{Environment.NewLine}         IsRowsAffected =  (cmd.ExecuteNonQuery() > 0);");

            _sbDataAccess.Append($@"{Environment.NewLine}       ");

            _sbDataAccess.Append($@"{Environment.NewLine}         ");
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     }}"); // Closing Sql Command

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}");// Closing sql Connection

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}   }}"); // Closing Try 

            _sbDataAccess.Append(_GetCatchCode().Replace("IsFound", "IsRowsAffected"));

            _sbDataAccess.Append($"{Environment.NewLine}   }}");
            _sbDataAccess.Append($"{Environment.NewLine}        return IsRowsAffected;");


            _sbDataAccess.Append($@"{Environment.NewLine}   }}");

        }





        private static void _GenerateDeleteObjectAsync()
        {

            clsColumn column = _PrimaryKeyCols.FirstOrDefault(c => c.IsPrimaryKey) ?? clsGlobal.CurrentTable.ClassColumns.FirstOrDefault();



            _sbDataAccess.Append($@"{"\n\n" + "\n"}    public static async Task<bool> Delete{clsGlobal.CurrentTable.TableSingularName}Async({column.ColumnType} {column.ColumnName})"); // Table Singular Name
            _sbDataAccess.Append($@"{Environment.NewLine}   {{");


            _sbDataAccess.Append($@"{Environment.NewLine}        bool IsRowsAffected = false;");


            _sbDataAccess.Append($@"{Environment.NewLine}   {_GetTryCode()}");

            _sbDataAccess.Append($@"{"\n\n "}   {_GetSqlConntionCode()}");
            _sbDataAccess.Append($@"{"\n\n "}     {_GetSqlCommandCode()
                .Replace("connection.Open()", "await connection.OpenAsync()")
                .Replace("SP", $"{clsGlobal.CurrentTable.TableName}_Delete{clsGlobal.CurrentTable.TableSingularName}")}"); // Table Name , Table Singular Name



            _sbDataAccess.Append($@"{_GetParamsForSqlCommand(column)}");



            _sbDataAccess.Append($@"{Environment.NewLine}         IsRowsAffected =  (await cmd.ExecuteNonQueryAsync() > 0);");

            _sbDataAccess.Append($@"{Environment.NewLine}         ");

            _sbDataAccess.Append($@"{Environment.NewLine}         ");
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     }}"); // Closing Sql Command

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}");// Closing sql Connection

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}"); // Closing Try 

            _sbDataAccess.Append(_GetCatchCode().Replace("IsFound", "IsRowsAffected"));

            _sbDataAccess.Append($"{Environment.NewLine}    }}");
            _sbDataAccess.Append($"{Environment.NewLine}        return IsRowsAffected;");


            _sbDataAccess.Append($@"{Environment.NewLine}     }}");



        }

        private static void _GenerateDeleteObject()
        {

            clsColumn column = _PrimaryKeyCols.FirstOrDefault(c => c.IsPrimaryKey) ?? clsGlobal.CurrentTable.ClassColumns.FirstOrDefault();



            _sbDataAccess.Append($@"{"\n\n" + "\n"}    public static bool Delete{clsGlobal.CurrentTable.TableSingularName}({column.ColumnType} {column.ColumnName})"); // Table Singular Name
            _sbDataAccess.Append($@"{Environment.NewLine}   {{");


            _sbDataAccess.Append($@"{Environment.NewLine}        bool IsRowsAffected = false;");


            _sbDataAccess.Append($@"{Environment.NewLine}   {_GetTryCode()}");

            _sbDataAccess.Append($@"{"\n\n "}   {_GetSqlConntionCode()}");
            _sbDataAccess.Append($@"{"\n\n "}     {_GetSqlCommandCode()

                .Replace("SP", $"{clsGlobal.CurrentTable.TableName}_Delete{clsGlobal.CurrentTable.TableSingularName}")}"); // Table Name , Table Singular Name



            _sbDataAccess.Append($@"{_GetParamsForSqlCommand(column)}");



            _sbDataAccess.Append($@"{Environment.NewLine}         IsRowsAffected =  (cmd.ExecuteNonQuery() > 0);");

            _sbDataAccess.Append($@"{Environment.NewLine}         ");

            _sbDataAccess.Append($@"{Environment.NewLine}         ");
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     }}"); // Closing Sql Command

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}");// Closing sql Connection

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}"); // Closing Try 

            _sbDataAccess.Append(_GetCatchCode().Replace("IsFound", "IsRowsAffected"));

            _sbDataAccess.Append($"{Environment.NewLine}    }}");
            _sbDataAccess.Append($"{Environment.NewLine}        return IsRowsAffected;");


            _sbDataAccess.Append($@"{Environment.NewLine}     }}");



        }




        private static void _GenerateGetAllRecordsAsync()
        {
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"} public static async Task<DataTable> GetAll{clsGlobal.CurrentTable.TableName}Async() {Environment.NewLine}    {{");
            _sbDataAccess.Append($@"{Environment.NewLine}    DataTable dt = new DataTable();{Environment.NewLine} ");
            _sbDataAccess.Append($@"{Environment.NewLine}   {_GetTryCode()}");


            _sbDataAccess.Append($@"{"\n\n "}   {_GetSqlConntionCode()}");

            _sbDataAccess.Append($@"{"\n\n "}     {_GetSqlCommandCode()
             .Replace("connection.Open()", "await connection.OpenAsync()")
             .Replace("SP", $"{clsGlobal.CurrentTable.TableName}_GetAll{clsGlobal.CurrentTable.TableName}")}"); // Table Name , Table  Name

            _sbDataAccess.Append($@"{_GetSqlDataReader().Replace("cmd.action", "await cmd.ExecuteReaderAsync()")}");

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}   if(reader.HasRows)");
            _sbDataAccess.Append($@"{Environment.NewLine}    dt.Load(reader);");
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}   else{"\n"}    dt = null;");

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}        }}"); // Closing Try 
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     }}"); // Closing Sql Command

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}");// Closing sql Connection

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}"); // Closing Try 


            _sbDataAccess.Append(_GetCatchCode().Replace("IsFound = false;", "dt = null;"));


            _sbDataAccess.Append($"{Environment.NewLine}    }}");

            _sbDataAccess.Append($"{Environment.NewLine}        return dt;");

            _sbDataAccess.Append($@"{Environment.NewLine}      }}");



        }


        private static void _GenerateGetAllRecords()
        {
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"} public static DataTable GetAll{clsGlobal.CurrentTable.TableName}() {Environment.NewLine}    {{");
            _sbDataAccess.Append($@"{Environment.NewLine}    DataTable dt = new DataTable();{Environment.NewLine} ");
            _sbDataAccess.Append($@"{Environment.NewLine}   {_GetTryCode()}");


            _sbDataAccess.Append($@"{"\n\n "}   {_GetSqlConntionCode()}");

            _sbDataAccess.Append($@"{"\n\n "}     {_GetSqlCommandCode()

             .Replace("SP", $"{clsGlobal.CurrentTable.TableName}_GetAll{clsGlobal.CurrentTable.TableName}")}"); // Table Name , Table  Name

            _sbDataAccess.Append($@"{_GetSqlDataReader().Replace("cmd.action", "cmd.ExecuteReader()")}");

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}   if(reader.HasRows)");
            _sbDataAccess.Append($@"{Environment.NewLine}    dt.Load(reader);");
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}   else{"\n"}    dt = null;");

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}        }}"); // Closing Try 
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     }}"); // Closing Sql Command

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}");// Closing sql Connection

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}"); // Closing Try 


            _sbDataAccess.Append(_GetCatchCode().Replace("IsFound = false;", "dt = null;"));


            _sbDataAccess.Append($"{Environment.NewLine}    }}");

            _sbDataAccess.Append($"{Environment.NewLine}        return dt;");

            _sbDataAccess.Append($@"{Environment.NewLine}      }}");



        }



        private static void _GenerateIsExistsMethodsAsync()
        {
            if (_PrimaryKeyCols.Count > 0)
                foreach (var col in _PrimaryKeyCols)
                {

                    _GenerateIsObjExistsAsync(col);
                }



            else
            {
                clsColumn col = clsGlobal.CurrentTable.ClassColumns.FirstOrDefault();
                _GenerateIsObjExistsAsync(col);
            }
        }
        private static void _GenerateIsObjExistsAsync(clsColumn col)
        {
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"} public static async Task<bool> Is{clsGlobal.CurrentTable.TableSingularName}ExistsAsync({col.ColumnType} {col.ColumnName}) {Environment.NewLine} {{");
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    bool IsFound = false; {Environment.NewLine + "\n"}");

            _sbDataAccess.Append(_GetTryCode());
            _sbDataAccess.Append(_GetSqlConntionCode());


            _sbDataAccess.Append(
               "\r  " + _GetSqlCommandCode().Replace("\"SP\"", $@"""{clsGlobal.CurrentTable.TableName}_Check{clsGlobal.CurrentTable.TableSingularName}Exists""")// Table Singular name // replceing "SP" From _GetSqlCommand With Actual Procedure name (TableName_Operation_ByColumnName);
               .Replace("connection.Open()", "await connection.OpenAsync()"));


            _sbDataAccess.Append(_GetParamsForSqlCommand(col));

            _sbDataAccess.Append(_GenerateSqlParam("returnParameter", "ReturnVal", col.ColumnType).Replace(".Output", ".ReturnValue"));


            _sbDataAccess.Append($@"{Environment.NewLine}         await cmd.ExecuteNonQueryAsync();");

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     IsFound = (int)returnParameter.Value == 1; {Environment.NewLine + "\n"}");

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     }}"); // Closing Sql Command

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}");// Closing sql Connection

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}   }}"); // Closing Try 

            _sbDataAccess.Append(_GetCatchCode());


            _sbDataAccess.Append($"{Environment.NewLine}   }}");

            _sbDataAccess.Append($"{Environment.NewLine}        return IsFound;");


            _sbDataAccess.Append($@"{Environment.NewLine}   }}");

        }

        private static void _GenerateIsExistsMethods()
        {
            if (_PrimaryKeyCols.Count > 0)
                foreach (var col in _PrimaryKeyCols)
                {

                    _GenerateIsObjExists(col);
                }



            else
            {
                clsColumn col = clsGlobal.CurrentTable.ClassColumns.FirstOrDefault();
                _GenerateIsObjExists(col);
            }
        }
        private static void _GenerateIsObjExists(clsColumn col)
        {
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"} public static bool Is{clsGlobal.CurrentTable.TableSingularName}Exists({col.ColumnType} {col.ColumnName}) {Environment.NewLine} {{");
            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    bool IsFound = false; {Environment.NewLine + "\n"}");

            _sbDataAccess.Append(_GetTryCode());
            _sbDataAccess.Append(_GetSqlConntionCode());


            _sbDataAccess.Append(
               "\r  " + _GetSqlCommandCode().Replace("\"SP\"", $@"""{clsGlobal.CurrentTable.TableName}_Check{clsGlobal.CurrentTable.TableSingularName}Exists"""));// Table Singular name // replceing "SP" From _GetSqlCommand With Actual Procedure name (TableName_Operation_ByColumnName


            _sbDataAccess.Append(_GetParamsForSqlCommand(col));

            _sbDataAccess.Append(_GenerateSqlParam("returnParameter", "ReturnVal", col.ColumnType).Replace(".Output", ".ReturnValue"));


            _sbDataAccess.Append($@"{Environment.NewLine}          cmd.ExecuteNonQuery();");

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     IsFound = (int)returnParameter.Value == 1; {Environment.NewLine + "\n"}");

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}     }}"); // Closing Sql Command

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}    }}");// Closing sql Connection

            _sbDataAccess.Append($@"{Environment.NewLine + "\n"}   }}"); // Closing Try 

            _sbDataAccess.Append(_GetCatchCode());


            _sbDataAccess.Append($"{Environment.NewLine}   }}");

            _sbDataAccess.Append($"{Environment.NewLine}        return IsFound;");


            _sbDataAccess.Append($@"{Environment.NewLine}   }}");

        }



        private static string _GenerateSqlParam(string ParamName, string ColName, string DataType)
        {

            string Param = $@"{"\n\n"}         SqlParameter {ParamName} = new SqlParameter(""@{ColName}"",{_GetSqlDbType(DataType)}){Environment.NewLine}         {{
                      Direction = ParameterDirection.Output
         }};";

            Param += $@"{Environment.NewLine + "\n"}         cmd.Parameters.Add({ParamName});";


            return Param;
        }

        private static string _GetSqlDbType(string csharpType)
        {
            switch (csharpType.ToLower())
            {
                case "byte": return "SqlDbType.TinyInt";
                case "short": return "SqlDbType.SmallInt";
                case "int": return "SqlDbType.Int";
                case "long": return "SqlDbType.BigInt";
                case "bool": return "SqlDbType.Bit";
                case "string": return "SqlDbType.NVarChar";
                case "char": return "SqlDbType.NChar";
                case "float": return "SqlDbType.Real";
                case "double": return "SqlDbType.Float";
                case "decimal": return "SqlDbType.Decimal";
                case "datetime": return "SqlDbType.DateTime";
                case "guid": return "SqlDbType.UniqueIdentifier";
                case "byte[]": return "SqlDbType.VarBinary";
                case "timespan": return "SqlDbType.Time";
                case "object": return "SqlDbType.Variant";
                default: return "Unknown";
            }

        }

        // Async
        private static string _GetSqlConntionCode()
        {


            string sqlconntion = $@"{Environment.NewLine + "\n"}     using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString)) {Environment.NewLine + "\n"}    {{";
            sqlconntion += $@"{Environment.NewLine} ";


            return sqlconntion; // The Right Carealy bracket is Messing
        }
        //  async
        private static string _GetSqlCommandCode()
        {
            string commandcode = $@"{Environment.NewLine + "\n"}      using (SqlCommand cmd = new SqlCommand(""SP"",connection)) {Environment.NewLine + "\n"}     {{";
            commandcode += $@"{Environment.NewLine + "\n"}        cmd.CommandType = CommandType.StoredProcedure; 
            {Environment.NewLine + "\n"}         connection.Open();";


            return commandcode;// The Right Carealy bracket is Messing
        }

        //  async
        private static string _GetSqlDataReader()
        {

            string datareader = $@"{Environment.NewLine + "\n"}        using (SqlDataReader reader =  cmd.action) {Environment.NewLine + "\n"}      {{";

            return datareader;  // The Right Carealy bracket is Messing
        }

        private static string _GetTryCode()
        {
            string tryconde = $@"{Environment.NewLine + "\n"}   try {Environment.NewLine}   {{
";

            return tryconde;
        }

        private static string _GetCatchCode()
        {

            string catchcode = $@"{Environment.NewLine + "\n"}   catch(SqlException ex) {Environment.NewLine}   {{";
            catchcode += $@"{Environment.NewLine + "\n"}    clsErrorEventLog.LogError(ex.Message);{Environment.NewLine}    IsFound = false;";

            return catchcode;
        }


        private static string _GetParamsForSqlCommand(clsColumn SearchByCol = null)
        {
            string ParamsList = "";


            // this is to generate the cmd one line like in the function GetByID , where all what I need is to send ID to the Procedure
            if (SearchByCol != null)
            {

                ParamsList += $@"{Environment.NewLine + "\n"}         cmd.Parameters.AddWithValue(""@{SearchByCol.ColumnName}"",{SearchByCol.ColumnName});";

                return ParamsList;
            }


            // if the execution goes here , this mean the method is used by either AddNew or Update where all the columns are needed to be send to the Procedure
            foreach (var col in clsGlobal.CurrentTable.ClassColumns)
            {
                if (col.IsNullable)
                {
                    ParamsList += _HandelNullableDataTypesWhenSavingInDB(col.ColumnName);
                    continue;
                }
                ParamsList += $@"{Environment.NewLine + "\n"}         cmd.Parameters.AddWithValue(""@{col.ColumnName}"",{col.ColumnName});";
            }

            return ParamsList;

        }

        private static string _AssignValuesToMethodParameters(clsColumn ColToSkip = null)
        {
            string AssignedParams = "";



            foreach (var col in clsGlobal.CurrentTable.ClassColumns)
            {
                // skiping the Column that is used for Getting the object ('like personId or whatever name)
                if (ColToSkip != null && col == ColToSkip)
                    continue;


                if (col.IsNullable)
                {
                    AssignedParams += _HandelNullableDataTypesWhenReadingFromDB(col.ColumnName, col.ColumnType);
                    continue;
                }

                AssignedParams += $@"{Environment.NewLine + "\n"}        {col.ColumnName} = {_AssignValuesToMethodParameter(col.ColumnName, col.ColumnType)} ";
            }

            return AssignedParams;
        }

        private static string _AssignValuesToMethodParameter(string ColName, string DataType)
        {

            return $"{_GetConversionFunction(DataType)}(reader[\"{ColName}\"]);";
        }

        private static string _HandelNullableDataTypesWhenReadingFromDB(string ColName, string datatype)
        {
            string NullableTypeText = "";



            NullableTypeText += $@"{Environment.NewLine + "\n"}        if(reader[""{ColName}""] ==  DBNull.Value) {Environment.NewLine}          {{";
            NullableTypeText += $@"{Environment.NewLine + "\n"}            {ColName} = null; {Environment.NewLine}          }}";
            NullableTypeText += $@"{Environment.NewLine}        else {Environment.NewLine}          {ColName} = {_AssignValuesToMethodParameter(ColName, datatype)}  ";

            return NullableTypeText;
        }

        private static string _HandelNullableDataTypesWhenSavingInDB(string ColName)
        {
            string NullableTypeText = "";

            NullableTypeText += $@"{Environment.NewLine + "\n"}     cmd.Parameters.AddWithValue(""@{ColName}"",(object){ColName} ?? DBNull.Value);";

            return NullableTypeText;
        }

        static string _GetConversionFunction(string dataType)
        {
            switch (dataType.ToLower())
            {
                case "int":
                    return "Convert.ToInt32";
                case "double":
                    return "Convert.ToDouble";
                case "string":
                    return "Convert.ToString";
                case "bool":
                    return "Convert.ToBoolean";
                case "decimal":
                    return "Convert.ToDecimal";
                case "datetime":
                    return "Convert.ToDateTime";
                case "long":
                    return "Convert.ToInt64";
                case "short":
                    return "Convert.ToInt16";
                case "byte":
                    return "Convert.ToByte";
                case "char":
                    return "Convert.ToChar";
                case "single":
                    return "Convert.ToSingle";
                case "ushort":
                    return "Convert.ToUInt16";
                case "uint":
                    return "Convert.ToUInt32";
                case "ulong":
                    return "Convert.ToUInt64";
                case "sbyte":
                    return "Convert.ToSByte";
                case "guid":
                    return "Convert.ToGuid";
                case "timespan":
                    return "Convert.ToTimeSpan";
                case "object":
                    return "Convert.ToObject";  // Convert to object type
                                                // Add more types as needed
                default:
                    return "Unknown conversion function";
            }
        }

        private static string GetColumnTypeString(string ColType, bool IsNullable)
        {
            return (IsNonNullableValueType(ColType) && IsNullable) ? ColType + "?" : ColType;
        }

        private static bool IsNonNullableValueType(string TypeName)
        {
            HashSet<string> Types = new HashSet<string>()
            {
                "bool","byte","sbyte",
                "char","decimal","double","float",
                "int","long","uint",
                "short","ulong","ushort","DateTime","Boolean","Int32","Int16","Int64","Char"
            };


            return Types.Contains(TypeName);
        }
    }
}
