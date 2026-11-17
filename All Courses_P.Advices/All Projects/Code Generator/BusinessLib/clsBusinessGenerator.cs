using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Global_Classes;

namespace BusinessLib
{
    public class clsBusinessGenerator
    {

        static StringBuilder _sbBusiness = new StringBuilder();
        static List<clsColumn> _PrimaryKeyCols = null;
        static clsBusinessGenerator()
        {

        }


        public static void SetBusinessGeneratorSettings(string TableName)
        {

           _sbBusiness.Clear();
            clsGlobal.CurrentTable.ClassColumns = clsUtil.GetAllTableColumnsForClass(TableName);


            // Get primary key columns  
            _PrimaryKeyCols = clsGlobal.CurrentTable.ClassColumns.Where(c => c.IsPrimaryKey).ToList();

        }




        private static string _GetMethodParametersList(bool PrimaryKey, bool WithDatatype, string Prefix = "")
        {
            string Params = "(";
            byte counter = 0; // this counter is used to make new line when 3 params are generated to avoid long parameters list

            if (PrimaryKey)
                foreach (var col in _PrimaryKeyCols)
                {
                    if (counter >= 3)
                    {
                        Params += "\r\n\t";
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
                if (counter >= 3)
                {
                    Params += "\r\n\t";
                    counter = 0;
                }

                counter++;
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
            _sbBusiness.Append("using System;\r\n");
            _sbBusiness.Append("using System.Collections.Generic;\r\n");
            _sbBusiness.Append("using System.Threading.Tasks;\r\n");
            _sbBusiness.Append("using System.Data;\r\n");
            _sbBusiness.Append($@"using {clsGlobal.DatabaseName.Replace(" ", "")}_DataAccess;{Environment.NewLine + "\n"}");
        }

        private static void _GenerateNamespace()
        {
            _sbBusiness.Append($@"{Environment.NewLine}namespace {clsGlobal.DatabaseName.Replace(" ","")}_Business {Environment.NewLine} {{");
        }



        private static void _GenerateClassHeader()
        {

            _sbBusiness.Append($@"{Environment.NewLine} public class {clsGlobal.CurrentTable.TableBusinessClassName} {Environment.NewLine}  {{");

        }

        private static void _GenerateClassProperties()
        {

            _sbBusiness.Append($@"{Environment.NewLine}     public enum enMode {{AddNew,Update}}");
            _sbBusiness.Append($@"{Environment.NewLine}     public enMode Mode {{get;set;}} = enMode.AddNew;{Environment.NewLine}");

            foreach (var col in clsGlobal.CurrentTable.ClassColumns)
            {
                _sbBusiness.Append(_GetValidPropertyShape(col.ColumnType, col.IsNullable, col.ColumnName));
            }

            _sbBusiness.Append($"{Environment.NewLine}");
        }

        private static string _GetValidPropertyShape(string ColumnType, bool IsNullable, string ColumnName)
        {
            return $@"{Environment.NewLine}     public {GetColumnTypeString(ColumnType, IsNullable)} {ColumnName} {{get;set;}}{Environment.NewLine}";
        }


        private static void _GenerateDefaultConstructor()
        {
            _sbBusiness.Append($@"{Environment.NewLine + "\r\n"} public {clsGlobal.CurrentTable.TableBusinessClassName}() {Environment.NewLine} {{");


            foreach (var col in clsGlobal.CurrentTable.ClassColumns)
            {
                _sbBusiness.Append($@"{Environment.NewLine}     this.{col.ColumnName} = default;{Environment.NewLine}");
            }


            _sbBusiness.Append("\r\n      Mode = enMode.AddNew;");
            _sbBusiness.Append($"{Environment.NewLine} }}");

        }


        private static void _GenerateParamtrizedConstructor()
        {
            _sbBusiness.Append($@"{Environment.NewLine + "\r\n"} private {clsGlobal.CurrentTable.TableBusinessClassName}{_GetMethodParametersList(true, true)}{Environment.NewLine} {{");


            foreach (var col in clsGlobal.CurrentTable.ClassColumns)
            {
                _sbBusiness.Append($@"{Environment.NewLine}      this.{col.ColumnName} = {col.ColumnName};{Environment.NewLine}");
            }


            _sbBusiness.Append("\r\n      Mode = enMode.Update;");
            _sbBusiness.Append($"{Environment.NewLine}  }}");
        }


        // async
        private static void _GenerateAddNewObjectMethodAsync()
        {
            clsColumn column = _PrimaryKeyCols.FirstOrDefault() ?? clsGlobal.CurrentTable.ClassColumns.FirstOrDefault();
            _sbBusiness.Append($@"{Environment.NewLine + "\n"} private async Task<bool> _AddNew{clsGlobal.CurrentTable.TableSingularName}Async(){Environment.NewLine} {{");

            _sbBusiness.Append($@"{Environment.NewLine}  this.{column.ColumnName} = await (");
            _sbBusiness.Append($@"{clsGlobal.CurrentTable.TableDataAccessClassName}.AddNew{clsGlobal.CurrentTable.TableSingularName}Async{Environment.NewLine}   {_GetMethodParametersList(true, false, "this.")});");

            _sbBusiness.Append($@"{Environment.NewLine}   return {column.ColumnName} != 0;{Environment.NewLine} }}");

        }

        private static void _GenerateAddNewObjectMethod()
        {
            clsColumn column = _PrimaryKeyCols.FirstOrDefault() ?? clsGlobal.CurrentTable.ClassColumns.FirstOrDefault();
            _sbBusiness.Append($@"{Environment.NewLine + "\n"} private  bool _AddNew{clsGlobal.CurrentTable.TableSingularName}(){Environment.NewLine} {{");

            _sbBusiness.Append($@"{Environment.NewLine}  this.{column.ColumnName} =  (");
            _sbBusiness.Append($@"{clsGlobal.CurrentTable.TableDataAccessClassName}.AddNew{clsGlobal.CurrentTable.TableSingularName}{Environment.NewLine}   {_GetMethodParametersList(true, false, "this.")});");

            _sbBusiness.Append($@"{Environment.NewLine}   return {column.ColumnName} != 0;{Environment.NewLine} }}");

        }





        // async
        private static void _GenerateUpdateObjectMethodAsync()
        {

            _sbBusiness.Append($@"{Environment.NewLine + "\n"} private async Task<bool> _Update{clsGlobal.CurrentTable.TableSingularName}Async(){Environment.NewLine} {{");

            _sbBusiness.Append($@"{Environment.NewLine}   return await {clsGlobal.CurrentTable.TableDataAccessClassName}.Update{clsGlobal.CurrentTable.TableSingularName}Async {_GetMethodParametersList(true, false)}; {Environment.NewLine} }}");

        }


        private static void _GenerateUpdateObjectMethod()
        {

            _sbBusiness.Append($@"{Environment.NewLine + "\n"} private bool _Update{clsGlobal.CurrentTable.TableSingularName}(){Environment.NewLine} {{");

            _sbBusiness.Append($@"{Environment.NewLine}   return  {clsGlobal.CurrentTable.TableDataAccessClassName}.Update{clsGlobal.CurrentTable.TableSingularName} {_GetMethodParametersList(true, false)}; {Environment.NewLine} }}");

        }

        // Async
        private static void _GenerateDeleteObjectMethodAsync()
        {

            clsColumn column = _PrimaryKeyCols.FirstOrDefault() ?? clsGlobal.CurrentTable.ClassColumns.FirstOrDefault();
            _sbBusiness.Append($@"{Environment.NewLine + "\n"} public static async Task<bool> Delete{clsGlobal.CurrentTable.TableSingularName}Async({column.ColumnType} {column.ColumnName}){Environment.NewLine} {{");

            _sbBusiness.Append($@"{Environment.NewLine}   return await {clsGlobal.CurrentTable.TableDataAccessClassName}.Delete{clsGlobal.CurrentTable.TableSingularName}Async ({column.ColumnName}); {Environment.NewLine} }}");

        }



        private static void _GenerateDeleteObjectMethod()
        {

            clsColumn column = _PrimaryKeyCols.FirstOrDefault() ?? clsGlobal.CurrentTable.ClassColumns.FirstOrDefault();
            _sbBusiness.Append($@"{Environment.NewLine + "\n"} public static bool Delete{clsGlobal.CurrentTable.TableSingularName}({column.ColumnType} {column.ColumnName}){Environment.NewLine} {{");

            _sbBusiness.Append($@"{Environment.NewLine}   return  {clsGlobal.CurrentTable.TableDataAccessClassName}.Delete{clsGlobal.CurrentTable.TableSingularName} ({column.ColumnName}); {Environment.NewLine} }}");

        }



        private static void _GenerateFindMethods()
        {
            foreach (var col in _PrimaryKeyCols)
                _GenerateFind(col);
        }
        
        private static void _GenerateFind(clsColumn col)
        {

            _sbBusiness.Append($@"{Environment.NewLine + "\n"} public static {clsGlobal.CurrentTable.TableBusinessClassName} Find({col.ColumnType} {col.ColumnName}) {Environment.NewLine} {{");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}     {_GetMethodParametersList(true, true).
                 Replace($"{col.ColumnType} {col.ColumnName}, ", "")
                .Replace(", ", " = default;")
                .Replace("(", "")
                .Replace(")", " = default;")
                }{Environment.NewLine + "\n"} ");

            _sbBusiness.Append($@"{Environment.NewLine + "\n"} bool IsFound =  {clsGlobal.CurrentTable.TableDataAccessClassName}.Get{clsGlobal.CurrentTable.TableSingularName}By{col.ColumnName}
               {_GetMethodParametersList(true, false, "ref ").Replace($"ref {col.ColumnName}, ", $"{col.ColumnName}, ")};");


            _sbBusiness.Append($@"{Environment.NewLine + "\n"} if(IsFound) {{ {Environment.NewLine}   return new {clsGlobal.CurrentTable.TableBusinessClassName}
                   {_GetMethodParametersList(true, false)};{Environment.NewLine + "\n"}}}");


            _sbBusiness.Append($@"{Environment.NewLine + "\n"} return  null;{Environment.NewLine + "\n"}}} {Environment.NewLine + "\n"}");


        }


        private static void _GenerateIsExistsAsyncMethods()
        {
            foreach (var col in _PrimaryKeyCols)
                _GenerateIsExistsAsync(col);
        }



        //Async


        private static void _GenerateIsExistsAsync(clsColumn col)
        {
            _sbBusiness.Append($@"{Environment.NewLine + "\n"} public static async Task<bool> Is{clsGlobal.CurrentTable.TableSingularName}ExistsAsync({col.ColumnType} {col.ColumnName}) {Environment.NewLine} {{");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}  return  await {clsGlobal.CurrentTable.TableDataAccessClassName}.Is{clsGlobal.CurrentTable.TableSingularName}ExistsAsync({col.ColumnName}); {Environment.NewLine + "\n"} }}");

        }



        private static void _GenerateIsExistsMethods()
        {
            foreach (var col in _PrimaryKeyCols)
                _GenerateIsExists(col);
        }


        private static void _GenerateIsExists(clsColumn col)
        {
            _sbBusiness.Append($@"{Environment.NewLine + "\n"} public static bool Is{clsGlobal.CurrentTable.TableSingularName}Exists({col.ColumnType} {col.ColumnName}) {Environment.NewLine} {{");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}  return   {clsGlobal.CurrentTable.TableDataAccessClassName}.Is{clsGlobal.CurrentTable.TableSingularName}Exists({col.ColumnName}); {Environment.NewLine + "\n"} }}");

        }

        // Async
        private static void _GenerateGetAllRecordsAsync()
        {
            _sbBusiness.Append($@"{Environment.NewLine + "\n"} public static async Task<DataTable> GetAll{clsGlobal.CurrentTable.TableName}Async() {Environment.NewLine} {{");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}  return  await {clsGlobal.CurrentTable.TableDataAccessClassName}.GetAll{clsGlobal.CurrentTable.TableName}Async(); {Environment.NewLine + "\n"} }}");

        }



        private static void _GenerateGetAllRecords()
        {
            _sbBusiness.Append($@"{Environment.NewLine + "\n"} public static DataTable GetAll{clsGlobal.CurrentTable.TableName}() {Environment.NewLine} {{");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}  return   {clsGlobal.CurrentTable.TableDataAccessClassName}.GetAll{clsGlobal.CurrentTable.TableName}(); {Environment.NewLine + "\n"} }}");

        }

        //Async
        private static void _GenerateSaveMethodAsync()
        {

            _sbBusiness.Append($@"{Environment.NewLine + "\n"}  public async Task<bool> Save() {Environment.NewLine} {{");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}   switch(Mode) {Environment.NewLine}   {{");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}    case enMode.AddNew:{Environment.NewLine}    if( await _AddNew{clsGlobal.CurrentTable.TableSingularName}Async()){Environment.NewLine}    {{"); // Table Singular Name
            _sbBusiness.Append($@"{Environment.NewLine}       Mode = enMode.Update; {Environment.NewLine}       return true;{Environment.NewLine}    }}");
            _sbBusiness.Append($@"{Environment.NewLine}    else  {Environment.NewLine}      return false;");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}       case enMode.Update: {Environment.NewLine}        return await _Update{clsGlobal.CurrentTable.TableSingularName}Async(); {Environment.NewLine + "\n"}  }}");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}    return false; {Environment.NewLine} }}");
            _sbBusiness.Append("\r\n\r\n\r\n");

        }

        private static void _GenerateSaveMethod()
        {

            _sbBusiness.Append($@"{Environment.NewLine + "\n"}  public bool Save() {Environment.NewLine} {{");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}   switch(Mode) {Environment.NewLine}   {{");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}    case enMode.AddNew:{Environment.NewLine}    if(  _AddNew{clsGlobal.CurrentTable.TableSingularName}()){Environment.NewLine}    {{"); // Table Singular Name
            _sbBusiness.Append($@"{Environment.NewLine}       Mode = enMode.Update; {Environment.NewLine}       return true;{Environment.NewLine}    }}");
            _sbBusiness.Append($@"{Environment.NewLine}    else  {Environment.NewLine}      return false;");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}       case enMode.Update: {Environment.NewLine}        return  _Update{clsGlobal.CurrentTable.TableSingularName}(); {Environment.NewLine + "\n"}  }}");
            _sbBusiness.Append($@"{Environment.NewLine + "\n"}    return false; {Environment.NewLine} }}");
            _sbBusiness.Append("\r\n\r\n\r\n");

        }

        private static void GenerateBusinessAsync()
        {
            _GenerateUsingHeader();
            _GenerateNamespace();
            _GenerateClassHeader();
            _GenerateClassProperties();
            _GenerateDefaultConstructor();
            _GenerateParamtrizedConstructor();
            _GenerateAddNewObjectMethodAsync();
            _GenerateUpdateObjectMethodAsync();
            _GenerateDeleteObjectMethodAsync();
            _GenerateFindMethods();
            _GenerateIsExistsAsyncMethods();
            _GenerateGetAllRecordsAsync();
            _GenerateSaveMethodAsync();
            _sbBusiness.Append($@"{Environment.NewLine}    }}"); // closing the class 
            _sbBusiness.Append($@"{Environment.NewLine}  }}"); // closing namspace
        }

        private static void GenerateBusiness()
        {
            _GenerateUsingHeader();
            _GenerateNamespace();
            _GenerateClassHeader();
            _GenerateClassProperties();
            _GenerateDefaultConstructor();
            _GenerateParamtrizedConstructor();
            _GenerateAddNewObjectMethod();
            _GenerateUpdateObjectMethod();
            _GenerateDeleteObjectMethod();
            _GenerateFindMethods();
            _GenerateIsExistsMethods();
            _GenerateGetAllRecords();
            _GenerateSaveMethod();
            _sbBusiness.Append($@"{Environment.NewLine}    }}"); // closing the class 
            _sbBusiness.Append($@"{Environment.NewLine}  }}"); // closing namspace
        }



        public static string GetBusinessGeneratedCode()
        {
            GenerateBusiness();
            return _sbBusiness.ToString();
        }

        public static string GetBusinessGeneratedCodeAsync()
        {
            GenerateBusinessAsync();
            return _sbBusiness.ToString();
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
