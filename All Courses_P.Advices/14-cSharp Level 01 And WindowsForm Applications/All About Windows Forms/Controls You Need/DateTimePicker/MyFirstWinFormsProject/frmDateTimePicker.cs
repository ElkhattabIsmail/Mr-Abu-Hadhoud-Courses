using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Text + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd-MMM-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd-MMM-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("MM-dd-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd/MM/yy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd,dd-MMM-yyyy") + Environment.NewLine;

        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.Year.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.Month.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.AddMonths(6).ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.AddDays(3000).ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLocalTime().ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToFileTime().ToString());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToFileTimeUtc().ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToUniversalTime().ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToOADate().ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortTimeString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongTimeString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;


            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
    }
}
