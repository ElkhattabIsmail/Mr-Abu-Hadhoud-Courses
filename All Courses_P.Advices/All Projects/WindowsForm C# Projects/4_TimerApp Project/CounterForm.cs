using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp_Project_04
{
    public partial class frmCountDown : Form
    {
        public frmCountDown()
        {
            InitializeComponent();
        }

        int TimeInMs, TimeInSec, TimeInMin, TimeInHours;
        bool isActive;
        private byte i = 0;
        private void frmCountDown_Load(object sender, EventArgs e)
        {
            ResetTime();
            isActive = false;
            
        }

        private void ResetTime()
        {
            TimeInMs = 0;
            TimeInSec = 0;
            TimeInMin = 0;
            TimeInHours = 0;
        }


    
        private void button1_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTime();

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //while (listView1.Items.Count > 0)
            //{
            //    listView1.Items.Remove(listView1.Items[0]);
            //}
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
                i = 0;
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            while (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                i--;
            }
        }

        private void btnCapt_Click(object sender, EventArgs e)
        {
            if (!isActive)
            {
                return;
            }
            i++;
            string txtCapture = TimeInHours.ToString("D2") + ":" + TimeInMin.ToString("D2") +
                ":" + TimeInSec.ToString("D2") + ":" + TimeInMs.ToString("D2");

            listView1.Items.Add("Timer "+ i.ToString("D2") + ": " + txtCapture);
        
        }

      
        private void ChangeLabel()
        {
            H.Text = string.Format("{0:00}", TimeInHours);
            Min.Text = string.Format("{0:00}", TimeInMin);
            Sec.Text = string.Format("{0:00}", TimeInSec);
            Ms.Text = string.Format("{0:000}", TimeInMs);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                TimeInMs++;
                if (TimeInMs >= 100)
                {
                    TimeInSec++;
                    TimeInMs = 0;

                    if (TimeInSec >= 60)
                    {
                        TimeInMin++;
                        TimeInSec = 0;
                    }
                    if (TimeInMin >= 60)
                    {
                        TimeInHours++;
                        TimeInMin = 0;
                    }
                }
            }
            ChangeLabel();
        }

        
    }
}
