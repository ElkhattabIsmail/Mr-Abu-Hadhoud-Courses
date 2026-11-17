using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimerApp_Project_04.Properties;

namespace TimerApp_Project_04
{
    public partial class CounterForm : Form
    {
        public CounterForm()
        {
            InitializeComponent();
           
        }
        private Int32 UpdatedCounter = 0;
        private Int32 MaxCounter = 0;

        private void CounterForm_Load(object sender, EventArgs e)
        {
           
        }

        private Int32 GetUpDownValueInSeconds()
        { 
            return (Int32)numericUpDown1.Value + ((Int32)numericUpDown2.Value * 60)
                   + ((Int32)ud1.Value * 60 * 60);
        }

        private string FormStr (string text)
        {
            if (text.Length <= 1)
            {
                return "0" + text;
            }
            else
            {
                return text;
            }
        }
        private void ChangeCounterLabel()
        {
            if (UpdatedCounter >= 60)
            {
                if (UpdatedCounter < 3600)
                    label6.Text = "00:" + FormStr((UpdatedCounter / 60).ToString()) + ":" + FormStr((UpdatedCounter % 60).ToString("D2"));
                else
                    label6.Text = FormStr((UpdatedCounter / 3600).ToString()) + ":" +
                      FormStr(((UpdatedCounter % 3600) / 60).ToString("D2")) + ":" + FormStr((UpdatedCounter % 60).ToString("D2"));
            }

            else
            {
                label6.Text = "00:" + "00:" + FormStr(UpdatedCounter.ToString());
            }
        }
    

        private void GetCounterValueFromN_upDown()
        {
            // UpdatedCounter = All Numeric Value in Sec
            UpdatedCounter = GetUpDownValueInSeconds();

            MaxCounter = UpdatedCounter;
            cBar.Value = cBar.Maximum;

            ChangeCounterLabel();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GetCounterValueFromN_upDown();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            GetCounterValueFromN_upDown();
        }
        private void ud1_ValueChanged(object sender, EventArgs e)
        {
            GetCounterValueFromN_upDown();

        }

        

        private void PicChange(PictureBox pb)
        {
            if (ud1.Value == 0 && numericUpDown1.Value == 0 && numericUpDown2.Value == 0)
                return;


            cBar.Maximum = MaxCounter;


            if (pb.Tag.ToString() == "Play")
            {
                

                // Run The Timer
                timer1.Start();

                cBar.Value = UpdatedCounter;

                pb.Image = Resources.Pause_removebg_preview;
                pb.Tag = "Pause";

                // Disable NumericUpdown Control
                ud1.Enabled = false;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                return;
            }
            // pb = Pause
            else
            {
                // TimerOff
                timer1.Stop();

                pb.Image = Resources.Play_removebg_preview;
                pb.Tag = "Play";

                // Enable NumericUpdown Control
                ud1.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                return;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PicChange((PictureBox)sender);
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (UpdatedCounter == 0)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipText = "Timer Is Finishing";
                notifyIcon1.ShowBalloonTip(3000);

                cBar.Value = cBar.Maximum;
                //  TimerOff
                timer1.Stop();

                pictureBox1.Image = Resources.Play_removebg_preview;
                pictureBox1.Tag = "Play";

                // ReCall The fun to get Text Too
                GetCounterValueFromN_upDown();

                // Enable NumericUpdown Control
                ud1.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;

                return;
            }

            // Increase From The CircularBar
            UpdatedCounter--;
            cBar.Value = UpdatedCounter;

            // increse From The Label of Counter
            ChangeCounterLabel();
         
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            //MessageBox.Show("BalloonTip Clicked :-)");
            // You can Do any Thing You Want to Do Here
            System.Diagnostics.Process.Start("https://fr.images.search.yahoo.com/search/images;_ylt=Awr.hk970t5mQAQAFlIk24lQ;_ylu=Y29sbwNpcjIEcG9zAzEEdnRpZAMEc2VjA3BpdnM-?p=%D8%B5%D9%84+%D8%B9%D9%84%DB%8C+%D9%85%D8%AD%D9%85%D8%AF&fr2=piv-web&type=E210FR91105G0&fr=mcafee&guccounter=1&guce_referrer=aHR0cHM6Ly9mci5zZWFyY2gueWFob28uY29tL3NlYXJjaDtfeWx0PUF3ci5oazlzMHQ1bVZ3UUFLcUFrMjRsUTtfeWxjPVgxTURNVE0xTVRJeE1UZ3hNZ1JmY2dNeUJHWnlBMjFqWVdabFpRUm1jaklEYzJJdGRHOXdCR2R3Y21sa0EwWTJVekZ6Y1VvelZFZ3lVbUZMVkdGdFZsWmpka0VFYmw5eWMyeDBBekFFYmw5emRXZG5BekVFYjNKcFoybHVBMlp5TG5ObFlYSmphQzU1WVdodmJ5NWpiMjBFY0c5ekF6QUVjSEZ6ZEhJREJIQnhjM1J5YkFNd0JIRnpkSEpzQXpFeUJIRjFaWEo1QXlVeU1DVkVPQ1ZDTlNWRU9TVTROQ1V5TUNWRU9DVkNPU1ZFT1NVNE5DVkVRaVU0UXlVeU1DVkVPU1U0TlNWRU9DVkJSQ1ZFT1NVNE5TVkVPQ1ZCUmdSMFgzTjBiWEFETVRjeU5UZzNPRGt3TnctLT9wPSslRDglQjUlRDklODQrJUQ4JUI5JUQ5JTg0JURCJThDKyVEOSU4NSVEOCVBRCVEOSU4NSVEOCVBRiZmcj1tY2FmZWUmdHlwZT1FMjEwRlI5MTEwNUcwJmZyMj1zYi10b3A&guce_referrer_sig=AQAAALw4bfC43f0csKGsSIuXhykvxmRSIPzMQRlNb8AONXoUzNDS9DaRr5logi-o2rnbyJnnU95hpMHl0ZMwbdTeNK-kkFo2FXCEDZHk3CzH7TG3rb4AvnDqLEXVQvvYHUGybyxsREAN8zCiy2rRZp47TW6q8tL2btv-h3wwRMWs827d");
        }

    }
}
