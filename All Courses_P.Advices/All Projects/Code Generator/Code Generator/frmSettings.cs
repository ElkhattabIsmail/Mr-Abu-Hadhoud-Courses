using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Generator.Properties;

namespace Code_Generator
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void chkboxChangeConnectionString_CheckedChanged(object sender, EventArgs e)
        {
            txtConnectionString.ReadOnly = !chkboxChangeConnectionString.Checked;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtConnectionString.Text = Settings.Default.ConnectionString ?? "";
            txtBusinessPath.Text = Settings.Default.BusinessFolderPath ?? "";
            txtDataAccessPath.Text = Settings.Default.DataAccessFolderPath ?? "";
            txtProceduresPath.Text = Settings.Default.ProceduresFolderPath ?? "";


        }


        private void ChangePath_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            folderBrowserDialog1.SelectedPath = @"C:\";



            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string NewPath = folderBrowserDialog1.SelectedPath;
                AssingePathToCorrectVarible(btn.Name, NewPath);
                SetTheNewPathToCorrectTextBox(btn.Tag.ToString(), NewPath);

            }

        }

        private void AssingePathToCorrectVarible(string ButtonName, string NewPath)
        {
            switch (ButtonName)
            {
                case "btnChangeBusinessPath":
                    Settings.Default.BusinessFolderPath = NewPath;
                    break;
                case "btnChangeDataAccessPath":
                    Settings.Default.DataAccessFolderPath = NewPath;
                    break;
                case "btnChangeProceudresPath":
                    Settings.Default.ProceduresFolderPath = NewPath;
                    break;
                default: throw new ArgumentException("Unknown Button Name");
            }

            Settings.Default.Save();
        }


        private void SetTheNewPathToCorrectTextBox(string btnTag, string NewPath)
        {
            switch (btnTag)
            {
                case "Business":
                    txtBusinessPath.Text = NewPath;
                    return;
                case "DataAccess":
                    txtDataAccessPath.Text = NewPath;
                    return;
                case "Procedures":
                    txtProceduresPath.Text = NewPath;
                    return;

                default: throw new ArgumentException("No Button with name " + btnTag);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Fill all the fields please ", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }



            Settings.Default.ConnectionString = txtConnectionString.Text;
            Settings.Default.BusinessFolderPath = txtBusinessPath.Text;
            Settings.Default.DataAccessFolderPath = txtDataAccessPath.Text;
            Settings.Default.ProceduresFolderPath = txtProceduresPath.Text;

            Settings.Default.Save();
            MessageBox.Show("All new settings are saved successfully", "Operation Performed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



    }
}
