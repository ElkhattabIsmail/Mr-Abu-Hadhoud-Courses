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
    public partial class CountriesForm : Form
    {
        public CountriesForm()
        {
            InitializeComponent();
        }
        private void GetAllCountries()
        {
            dgvAllCountries.DataSource = clsCountry.GetAllCountries();
        }
        private void CountriesForm_Load(object sender, EventArgs e)
        {
            GetAllCountries();
        }

        private void lblAllCountries_Click(object sender, EventArgs e)
        {

        }
    }
}
