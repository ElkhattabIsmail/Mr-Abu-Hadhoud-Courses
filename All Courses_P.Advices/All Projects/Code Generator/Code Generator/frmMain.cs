using Global_Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLib;
using DataAccessLib;
using System.IO;
using System.Text;
using System.Diagnostics;
using Code_Generator.Properties;
using System.Linq;
namespace Code_Generator
{
    public partial class frmMain : Form
    {

        private List<string> _DatabasesNames;

        private List<string> _TablesNames;

        private Action _BusinessDel = EmptyMethod;
        private Action _DataAccessDel = EmptyMethod;
        private Action _ProcedureDel = EmptyMethod;


        public frmMain()
        {
            InitializeComponent();


            clsGlobal.SetConnectionString(Settings.Default.ConnectionString);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {


            FillDatabasesNamesInCombobox();
            cbDatabases.SelectedIndex = 0;


        }


        private void FillDatabasesNamesInCombobox()
        {
            _DatabasesNames = clsUtil.GetAllDatabasesNames();
            cbDatabases.Items.AddRange(_DatabasesNames.ToArray());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsGlobal.DatabaseName = cbDatabases.SelectedItem.ToString();
            FillTheCheckboxListWithTables();
            checkBox1.Checked = false;

        }


        private void FillTheCheckboxListWithTables()
        {
            chkboxTables.Items.Clear();

            _TablesNames = clsUtil.GetAllTablesByDatabaseName(clsGlobal.DatabaseName);

            chkboxTables.Items.AddRange(_TablesNames.ToArray());


            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ChangeAllListItemsStatus(true);
            }
            else
            {
                ChangeAllListItemsStatus(false);
            }
        }

        private void ChangeAllListItemsStatus(bool Val = true)
        {
            for (byte i = 0; i < chkboxTables.Items.Count; i++)
            {
                chkboxTables.SetItemChecked(i, Val);

            }
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {


            var Items = chkboxTables.CheckedItems.Cast<object>();
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            foreach (var item in Items)
            {
                // get the table name
                clsGlobal.CurrentTable.TableName = item.ToString();




                _PrepareBusinessAndDataAccessDelegatesBeforeGeneration(chkBusinessLayer, rdioSync, ref _BusinessDel, _GenerateBusiness, _GenerateBusinessAsync);
                _PrepareBusinessAndDataAccessDelegatesBeforeGeneration(chkDataAccessLayer, rdioSync, ref _DataAccessDel, _GenerateDataAccess, _GenerateDataAccessAsync);

                _PrepareProceudreDelegate();



                Task.WaitAll(Task.Run(() => _BusinessDel.Invoke()),
                    Task.Run(() => _DataAccessDel.Invoke()),
                    Task.Run(() => _ProcedureDel.Invoke()));
            }


            _GenerateOtherClasses(chkBusinessLayer, _GenerateDateHelperClass);
            _GenerateOtherClasses(chkDataAccessLayer, _GenerateDataAccessSettingsClass);
            _GenerateOtherClasses(chkDataAccessLayer, _GenerateErrorLoggerClass);
            _GenerateOtherClasses(chkDataAccessLayer, _GenerateAppManifest);


            stopwatch1.Stop();
            MessageBox.Show($"Classes Generated Successfully within {stopwatch1.ElapsedMilliseconds} ms!","Generation Completed",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }





        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }



        private void chkBusinessLayer_CheckedChanged(object sender, EventArgs e)
        {
            gpMethodsType.Enabled = (chkBusinessLayer.Checked || chkDataAccessLayer.Checked);
        }

        private void chkDataAccessLayer_CheckedChanged(object sender, EventArgs e)
        {
            gpMethodsType.Enabled = (chkBusinessLayer.Checked || chkDataAccessLayer.Checked);
        }

        private void chkProcedures_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProcedures.Checked)
            {
                _ProcedureDel = _GenerateStoredProcedures;

            }
            else
            {
                _ProcedureDel = EmptyMethod;
            }
        }



        private void _GenerateBusiness()
        {
            string BuisnessDirectory = $@"{Settings.Default.BusinessFolderPath}";

            string FilePath = $@"{BuisnessDirectory}\{clsGlobal.CurrentTable.TableBusinessClassName}.cs";


            clsBusinessGenerator.SetBusinessGeneratorSettings(clsGlobal.CurrentTable.TableName);

            File.WriteAllText(FilePath, clsBusinessGenerator.GetBusinessGeneratedCode(), Encoding.UTF8);


        }

        private void _GenerateBusinessAsync()
        {
            string BuisnessDirectory = $@"{Settings.Default.BusinessFolderPath}";

            string FilePath = $@"{BuisnessDirectory}\{clsGlobal.CurrentTable.TableBusinessClassName}.cs";


            clsBusinessGenerator.SetBusinessGeneratorSettings(clsGlobal.CurrentTable.TableName);

            File.WriteAllText(FilePath, clsBusinessGenerator.GetBusinessGeneratedCodeAsync(), Encoding.UTF8);


        }

        private void _GenerateDataAccess()
        {
            string DataAccessDirectory = $@"{Settings.Default.DataAccessFolderPath}";



            string FilePath = $@"{DataAccessDirectory}\{clsGlobal.CurrentTable.TableDataAccessClassName}.cs";


            clsDataAccessGenerator.SetDataAccessGeneratorSettings(clsGlobal.CurrentTable.TableName);

            File.WriteAllText(FilePath, clsDataAccessGenerator.GetDataAccessGeneratedCode(), Encoding.UTF8);


        }



        private void _GenerateDataAccessAsync()
        {
            string DataAccessDirectory = $@"{Settings.Default.DataAccessFolderPath}";



            string FilePath = $@"{DataAccessDirectory}\{clsGlobal.CurrentTable.TableDataAccessClassName}.cs";


            clsDataAccessGenerator.SetDataAccessGeneratorSettings(clsGlobal.CurrentTable.TableName);

            File.WriteAllText(FilePath, clsDataAccessGenerator.GetDataAccessGeneratedCodeAsync(), Encoding.UTF8);


        }

        private void _GenerateStoredProcedures()
        {
            string ProceduresDirectory = $@"{Settings.Default.ProceduresFolderPath}";



            string FilePath = $@"{ProceduresDirectory}\{clsGlobal.CurrentTable.TableName}.sql";


            clsProcedureGenertor.SetProcedureGeneratorSettings(clsGlobal.CurrentTable.TableName);

            File.WriteAllText(FilePath, clsProcedureGenertor.GetProceduresGeneratedScript(), Encoding.UTF8);

        }

        private void _GenerateDateHelperClass()
        {
            string FilePath = $@"{Settings.Default.BusinessFolderPath}\clsDataHelpr.cs";



            File.WriteAllText(FilePath, clsBusinessGlobalClasses.GenrateclsDataHelper(), Encoding.UTF8);


        }

        private void _GenerateDataAccessSettingsClass()
        {
            string FilePath = $@"{Settings.Default.DataAccessFolderPath}\clsDataAccessSettings.cs";



            File.WriteAllText(FilePath, clsDateAccessGlobalClasses.GenerateDataAccessSettings(), Encoding.UTF8);


        }



        private void _GenerateErrorLoggerClass()
        {
            string FilePath = $@"{Settings.Default.DataAccessFolderPath}\clsErrorEventLog.cs";



            File.WriteAllText(FilePath, clsDateAccessGlobalClasses.GenerateErrorLogger(), Encoding.UTF8);

        }


        private static void EmptyMethod() 
        {

        }


        private void _PrepareBusinessAndDataAccessDelegatesBeforeGeneration(CheckBox chk, RadioButton rdio, ref Action LayerDelegate, Action SyncGenerationMethod, Action ASyncGenerationMethod)
        {
            if (chk.Checked)
            {
                if (rdio.Checked)
                    LayerDelegate = SyncGenerationMethod;
                else
                    LayerDelegate = ASyncGenerationMethod;
            }
            else
                LayerDelegate = EmptyMethod;
        }

        private void _PrepareProceudreDelegate()
        {
            if (chkProcedures.Checked)
            {
                _ProcedureDel = _GenerateStoredProcedures;

            }
            else
            {
                _ProcedureDel = EmptyMethod;
            }
        }

        private void _GenerateOtherClasses(CheckBox chk, Action Function)
        {
            if (chk.Checked)
            {
                Function?.Invoke();
            }
        }

        private void _GenerateAppManifest()
        {

            string FilePath = $@"{Settings.Default.DataAccessFolderPath}\app.manifest";
            string Content = @"<?xml version=""1.0"" encoding=""utf-8""?>
<assembly manifestVersion=""1.0"" xmlns=""urn:schemas-microsoft-com:asm.v1"">
	<assemblyIdentity version=""1.0.0.0"" processorArchitecture=""X86"" name=""YourAppName"" type=""win32"" />
	<trustInfo xmlns=""urn:schemas-microsoft-com:asm.v2"">
		<security>
			<requestedPrivileges>
				<requestedExecutionLevel level=""requireAdministrator"" uiAccess=""false"" />
			</requestedPrivileges>
		</security>
	</trustInfo>
</assembly>";


            File.WriteAllText(FilePath, Content, Encoding.UTF8);
        }


    }


}
