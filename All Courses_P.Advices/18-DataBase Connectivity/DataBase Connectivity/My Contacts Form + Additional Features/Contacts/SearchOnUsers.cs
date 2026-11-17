using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class SearchOnUsers : Form
    {
        public SearchOnUsers()
        {
            InitializeComponent();
        }

        private void GetAllContactsWithStartLetter(string StartWith)
        {
            
            dgvSearch.DataSource = clsContact._GetAllContactsByStartLetterName( StartWith);
        }

        //public bool SearchForData = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.ToString() != "")
            {
                dgvSearch.Show();
                GetAllContactsWithStartLetter(txtSearch.Text.ToString());

            }
            else
            {
                dgvSearch.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAllContactsWithStartLetter(txtSearch.Text.ToString());
        }
    }
}
