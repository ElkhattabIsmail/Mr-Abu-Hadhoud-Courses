using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_BusinessLayer;

namespace Point_Of_Sales_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
         {

            //dataGridView1.DataSource = ClsUser.GetAll();


            ClsUser user = ClsUser.Find(15);
            if (user != null)
            {
                MessageBox.Show("Person Updated Successfully.");
                MessageBox.Show($"ID = {user.PersonID} , FullName = {user.UserName} {user.Permission}");
            }
            user.UserID = 11;
            user.PersonID = 9;
            user.UserName = "Agro01";
            user.Password  = "Abdo1999";
            user.Permission =  -1;
            user.IsActive  = true;
            user.mode = ClsUser.Mode.Update; 

            if (ClsUser.IsExist(1))
            {
                MessageBox.Show("Person Updated Successfully.");
            }

        }
    }
}
