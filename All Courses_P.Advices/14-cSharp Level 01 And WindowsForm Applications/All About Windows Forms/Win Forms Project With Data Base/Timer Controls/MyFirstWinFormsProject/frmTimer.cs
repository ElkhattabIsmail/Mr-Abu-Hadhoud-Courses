using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private int Counter = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled= false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter+= 10;
            
                if (Counter >= 60)
                {
                    if (Counter < 3600)
                        label1.Text = (Counter / 60).ToString() + ":" + (Counter % 60).ToString("D2");
                    else
                        label1.Text = (Counter / 3600).ToString() + ":" + ((Counter % 3600) / 60).ToString("D2") + ":" + (Counter % 60).ToString("D2");
                }

                else
                {
                    label1.Text = Counter.ToString();
                }
            }
           

        }
    }

