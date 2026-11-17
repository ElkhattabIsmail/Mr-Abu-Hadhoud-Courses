using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp_Project_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblNow.Text = DateTime.Now.ToLongTimeString();
            lblNowDate.Text = DateTime.Now.ToShortDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNow.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Do You Want To Exit", "Confirm", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            frmCountDown cd = new frmCountDown();
            cd.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CounterForm cf = new CounterForm();
            //cf.Show(); // تقدر ترجع تلعب في الفورم الأساسية
            cf.ShowDialog(); // but now you can't
        }
        

      
    }
}
