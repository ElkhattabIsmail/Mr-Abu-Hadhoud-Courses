using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Gen_DataAccess.GlobalClasses;
namespace CRUD_Gen_DataAccess
{
    public class clsProcedureGenertor
    {
        static StringBuilder _sbProcedures = new StringBuilder();
        static List<clsColumn> _PrimaryKeyCols = null;
        static clsProcedureGenertor()
        {

        }






        public static void SetProcedureGeneratorSettings(string TableName)
        {
            _sbProcedures.Clear();
            clsGlobal.CurrentTable.ProcedureColumns = clsUtil.GetAllTableColumnsForProcedure(TableName);


            // Get primary key columns  
            _PrimaryKeyCols = clsGlobal.CurrentTable.ProcedureColumns.Where(c => c.IsPrimaryKey).ToList();

        }


        public static string GetProceduresGeneratedScript()
        {
            _GenerateProcedureScript();

            _GenerateAddNewProcedure();
            _GenerateUpdateProcedure();
            _GenerateDeleteProcedure();
            _GenerateIsExistsProcedure();
            _GenerateGetObjectProcedure();
            _GenerateGetAllProcedure();

            return _sbProcedures.ToString();
        }

        private static void _GenerateProcedureScript()
        {
            _sbProcedures.Append($@"{"\r\n"}USE {clsGlobal.DatabaseName};{"\r\n\r\n"}");

        }



        static string _GetMethodParametersList(bool PrimaryKey, bool WithDatatype, string Prefix = "@", string Postfix = "")
        {
            string Params = "\r\n";
            byte counter = 0;



            if (PrimaryKey)
                foreach (var col in _PrimaryKeyCols)
                {
                    counter++;
                    if (counter >= 3)
                    {

                        counter = 0;
                    }





                    if (!WithDatatype)
                    {
                        Params += $@"{Prefix}{col.ColumnName},{"\r\n"}";
                        continue;
                    }

                    Params += $@"{Prefix}{col.ColumnName} {col.ColumnType},{"\r\n"}";

                }



            foreach (var col in clsGlobal.CurrentTable.ProcedureColumns)
            {
                counter++;
                if (counter >= 3)
                {

                    counter = 0;
                }
                if (!col.IsPrimaryKey)
                {

                    if (WithDatatype)
                    {
                        Params += $@"{Prefix}{col.ColumnName} {col.ColumnType},{"\r\n"}";// TheName is Before Data Type
                        continue;
                    }

                    Params += $@"{Prefix}{col.ColumnName}{Postfix},";


                }

            }



            return Params.Substring(0, Params.Length - 3) + "\r\n\r\nAS";

        }





        private static string _GenerateProcedureHeader(string ProcedureName, string operation)
        {
            string ProcHeader = $@"{"\r\n\r\n\r\n"}Go {"\r\n\r\n --------"}{operation + "--------\r\n\r\n"}";

            ProcHeader += $@"CREATE OR ALTER PROCEDURE {ProcedureName + "\r\n"}";

            return ProcHeader;
        }

        private static string _GenerateProcedureParametersListForInsert(List<clsColumn> Columns, bool WithDateType = false, string Prefix = "@", string Postfix = "")
        {
            string Parameters = "";


            foreach (clsColumn col in Columns)
            {
                if (WithDateType)
                {
                    Parameters += $@"{Prefix}{col.ColumnName} {col.ColumnType}{Postfix}, {"\r\n"}";
                    continue;
                }

                Parameters += $@"{Prefix}{col.ColumnName}{Postfix}, ";


            }

            return Parameters.Substring(0, Parameters.Length - 2);

        }

        private static string _GenerateProcedureParametersListForUpdate(List<clsColumn> Columns, bool WithDateType = false, string Postfix = "")
        {
            string Parameters = "";


            foreach (clsColumn col in Columns)
            {
                if (WithDateType)
                {
                    Parameters += $@"{col.ColumnName} {col.ColumnType}{Postfix}, {"\r\n"}";
                    continue;
                }

                Parameters += $@"{col.ColumnName} = @{col.ColumnName}, ";


            }

            return Parameters.Substring(0, Parameters.Length - 2);

        }

        private static void _GenerateAddNewProcedure()
        {


            clsColumn col = _GetFirstOrDefultColumn();


            string OutParam = $@"@New{col.ColumnName}";
            _sbProcedures.Append($@"{_GenerateProcedureHeader($"{clsGlobal.CurrentTable.TableName}_InsertNew{clsGlobal.CurrentTable.TableSingularName}", "INSERT")}");

            _sbProcedures.Append($@"{"\r\n" + _GenerateProcedureParametersListForInsert(clsGlobal.CurrentTable.ProcedureColumns.Where(c => c != col).ToList(), true)}"); // Skip the first column because it will be auto generated
            _sbProcedures.Append($@"{"\r\n"}{OutParam} {col.ColumnType} OUTPUT");
            _sbProcedures.Append("\r\n\r\nAS");
            _sbProcedures.Append($@"{_GetBeginBlock()}");
            _sbProcedures.Append($@"   INSERT INTO {clsGlobal.CurrentTable.TableName} ({_GenerateProcedureParametersListForInsert(clsGlobal.CurrentTable.ProcedureColumns.Where(c => c != col).ToList(), false, "")})"); // remove the prefix @
            _sbProcedures.Append($@"{"\r\n"}   VALUES ({_GenerateProcedureParametersListForInsert(clsGlobal.CurrentTable.ProcedureColumns.Where(c => c != col).ToList(), false)});");
            _sbProcedures.Append($@"{"\r\n"}   SET {OutParam} = SCOPE_IDENTITY();");
            _sbProcedures.Append(_GetEndBlock());
        }


        private static void _GenerateUpdateProcedure()
        {
            clsColumn col = _GetFirstOrDefultColumn();
            _sbProcedures.Append($@"{_GenerateProcedureHeader($"{clsGlobal.CurrentTable.TableName}_Update{clsGlobal.CurrentTable.TableSingularName}", "Update")}");


            _sbProcedures.Append(_GetMethodParametersList(true, true));
            _sbProcedures.Append(_GetBeginBlock("OFF"));

            _sbProcedures.Append($@"   Update {clsGlobal.CurrentTable.TableName} {"\r\n\r\n"}");
            _sbProcedures.Append($@"   SET {_GenerateProcedureParametersListForUpdate(clsGlobal.CurrentTable.ProcedureColumns.Where(c => c != col).ToList(), false, " = ")}");

            _sbProcedures.Append($@"{"\r\n"}   WHERE {col.ColumnName} = @{col.ColumnName};");

            _sbProcedures.Append(_GetRowsAffectedLine());

            _sbProcedures.Append(_GetEndBlock());

        }

        private static void _GenerateDeleteProcedure()
        {
            clsColumn col = _GetFirstOrDefultColumn();
            _sbProcedures.Append($@"{_GenerateProcedureHeader($"{clsGlobal.CurrentTable.TableName}_Delete{clsGlobal.CurrentTable.TableSingularName}", "Delete")}");


            _sbProcedures.Append($@"{"\r\n"}@{col.ColumnName} {col.ColumnType}{"\r\n\r\nAS"}");
            _sbProcedures.Append(_GetBeginBlock("OFF"));
            _sbProcedures.Append($@"{"\r\n"}    DELETE FROM {clsGlobal.CurrentTable.TableName}");

            _sbProcedures.Append($@"{"\r\n"}   WHERE {col.ColumnName} = @{col.ColumnName};");

            _sbProcedures.Append(_GetRowsAffectedLine());

            _sbProcedures.Append(_GetEndBlock());
        }

        private static void _GenerateIsExistsProcedure()
        {
            clsColumn col = _GetFirstOrDefultColumn();
            _sbProcedures.Append($@"{_GenerateProcedureHeader($"{clsGlobal.CurrentTable.TableName}_Check{clsGlobal.CurrentTable.TableSingularName}Exists", "Is Exists")}");


            _sbProcedures.Append($@"{"\r\n"}@{col.ColumnName} {col.ColumnType}{"\r\n\r\nAS"}");
            _sbProcedures.Append(_GetBeginBlock("ON"));
            _sbProcedures.Append($@"{"\r\n"}     IF EXISTS( SELECT 1 FROM {clsGlobal.CurrentTable.TableName} ");

            _sbProcedures.Append($@"{"\r\n"}     WHERE {col.ColumnName} = @{col.ColumnName})");

            _sbProcedures.Append($@"{"\r\n"}         RETURN 1;");
            _sbProcedures.Append($@"{"\r\n"}    ELSE");
            _sbProcedures.Append($@"{"\r\n"}         RETURN 0;");

            _sbProcedures.Append(_GetEndBlock());
        }


        private static void _GenerateGetObjectProcedure()
        {
            clsColumn col = _GetFirstOrDefultColumn();
            _sbProcedures.Append($@"{_GenerateProcedureHeader($"{clsGlobal.CurrentTable.TableName}_Get{clsGlobal.CurrentTable.TableSingularName}By{col.ColumnName}", "Get Record By")}");


            _sbProcedures.Append($@"{"\r\n"}@{col.ColumnName} {col.ColumnType}{"\r\n\r\nAS"}");
            _sbProcedures.Append(_GetBeginBlock("ON"));

            _sbProcedures.Append($@"    SELECT * FROM {clsGlobal.CurrentTable.TableName} WHERE {col.ColumnName} = @{col.ColumnName};");

            _sbProcedures.Append(_GetEndBlock());


        }

        private static void _GenerateGetAllProcedure()
        {

            _sbProcedures.Append($@"{_GenerateProcedureHeader($"{clsGlobal.CurrentTable.TableName}_GetAll{clsGlobal.CurrentTable.TableName}", "Get All Records")}");


            _sbProcedures.Append($@"{"\r\n"}{"\r\n\r\nAS"}");
            _sbProcedures.Append(_GetBeginBlock("ON"));

            _sbProcedures.Append($@"    SELECT * FROM {clsGlobal.CurrentTable.TableName};");

            _sbProcedures.Append(_GetEndBlock());
        }


        private static clsColumn _GetFirstOrDefultColumn()
        {
            return (_PrimaryKeyCols.Count > 0) ? _PrimaryKeyCols[0] : clsGlobal.CurrentTable.ProcedureColumns.FirstOrDefault();
        }


        private static string _GetBeginBlock(string CountVal = "ON")
        {
            return $@"{"\r\n\r\n"}BEGIN{"\r\n"}  SET NOCOUNT {CountVal};{"\r\n\r\n"}";
        }




        private static string _GetEndBlock()
        {
            return "\r\n\r\nEND\r\nGO";
        }

        private static string _GetRowsAffectedLine()
        {
            return "\r\n\r\n    SELECT @@ROWCOUNT AS RowsAffected;";
        }
    }
}
