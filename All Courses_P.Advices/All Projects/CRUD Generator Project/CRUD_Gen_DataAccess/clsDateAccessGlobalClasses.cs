using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Gen_DataAccess;
using CRUD_Gen_DataAccess.GlobalClasses;

namespace CRUD_Gen_DataAccess
{
    class clsDateAccessGlobalClasses
    {
        private static StringBuilder _sbGlobal = new StringBuilder();




        static clsDateAccessGlobalClasses()
        {

        }



        public static string GenerateDataAccessSettings()
        {
            _GenerateDataAccessSettings();

            return _sbGlobal.ToString();
        }

        public static string GenerateErrorLogger()
        {
            _GenerateErrorLogger();

            return _sbGlobal.ToString();
        }

        private static void _GenerateDataAccessSettings()
        {
            _GenerateDataAccessSettingsClass();
        }



        private static void _GenerateErrorLogger()
        {
            _GenerateErrorLoggerClass();
        }

        private static void _GenerateDataAccessSettingsClass()
        {
            _sbGlobal.Clear();


            _sbGlobal.Append($@"using System;");
            _sbGlobal.Append($@"{"\r\n"}using System.Configuration;");
            _sbGlobal.Append($@"{"\r\n"}namespace {clsGlobal.DatabaseName}_DataAccess   {Environment.NewLine}{{   {Environment.NewLine + "\r\n\n"}");
            _sbGlobal.Append($@"{"\r\n"} public class clsDataAccessSettings {Environment.NewLine + "\r\n\r\n"}   {{ ");
            _sbGlobal.Append($@"{"\r\n"}        public static readonly string ConnectionString = ConfigurationManager.AppSettings[""ConnectionString""];");
            _sbGlobal.Append($@"{Environment.NewLine + "\n\n"}   }}");
            _sbGlobal.Append($@"{Environment.NewLine + "\n\n"} }}");
            _sbGlobal.Append("\r\n\r\n// Copy this and paste it in a file named App.config and change the conntection string value \r\n\n" + @"/*<?xml version=""1.0"" encoding=""utf-8"" ?>
<configuration>
    <startup> 
        <supportedRuntime version=""v4.0"" sku="".NETFramework,Version=v4.8"" />
    </startup>

	<appSettings>
		<add key=""ConnectionString"" value=""Server=.;Database=YourDataBase;User Id=sa;Password=sa123456;""/>
	</appSettings>
</configuration>*/".Replace("YourDataBase", clsGlobal.DatabaseName));
        }


        private static void _GenerateErrorLoggerClass()
        {
            _sbGlobal.Clear();
            _sbGlobal.Append($@"using System;");
            _sbGlobal.Append($@"{"\r\n"}using System.Diagnostics;");
            _sbGlobal.Append($@"{"\r\n"}namespace {clsGlobal.DatabaseName}_DataAccess   {Environment.NewLine + "\r\n"}{{ {Environment.NewLine + "\n\n"}");
            _sbGlobal.Append($@"{"\r\n"} public class clsErrorEventLog {Environment.NewLine + "\r\n\n"}  {{");
            _sbGlobal.Append($@"{"\r\n"}         private static readonly string SourceName = ""{clsGlobal.DatabaseName}"";");
            _sbGlobal.Append($@"{"\r\n"}      static clsErrorEventLog(){"\r\n"}    {{");
            _sbGlobal.Append($@"{"\r\n\r\n"}       if (!EventLog.Exists(SourceName))  {"\r\n"}       {{");
            _sbGlobal.Append($@"{"\r\n"}              EventLog.CreateEventSource(SourceName, ""Application""); {"\r\n"}       }} {"\r\n"}    }}");
            _sbGlobal.Append($@"{"\r\n\r\n"}     public static void LogError(string ErrorMessage, EventLogEntryType entryType = EventLogEntryType.Error) {"\r\n"}    {{");
            _sbGlobal.Append($@"{"\r\n"}            EventLog.WriteEntry(SourceName, ErrorMessage, entryType); {"\r\n"}    }}");
            _sbGlobal.Append($@"{"\r\n\r\n"}   }}");
            _sbGlobal.Append($@"{"\r\n\r\n"}}}");



        }
    }
}
