using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rgb_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCopy.Click += btnCopy_Click; // subscribe the event
        }

        private void SetColors()
        {
            int a = trackBar1.Value;
            int r = trackBar2.Value;
            int g = trackBar3.Value;
            int b = trackBar4.Value;

            pbColor.BackColor = Color.FromArgb(a, r, g, b);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label12.Text = trackBar1.Value.ToString();
            SetColors();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label10.Text = trackBar2.Value.ToString();
            SetColors();

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label11.Text = trackBar3.Value.ToString();
            SetColors();

        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label13.Text = trackBar4.Value.ToString();
            SetColors();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int middleVal = 255 / 2;
            trackBar1.Value = middleVal;
            trackBar2.Value = middleVal;
            trackBar3.Value = middleVal;
            trackBar4.Value = middleVal;
            label10.Text = middleVal.ToString();
            label11.Text = middleVal.ToString();
            label12.Text = middleVal.ToString();
            label13.Text = middleVal.ToString();
            pbColor.BackColor = Color.FromArgb(middleVal, middleVal,
                middleVal, middleVal);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("A : " + label12.Text + "- R : " + label11.Text + "- G : " + label10.Text
                + "- B : " + label13.Text);
            //string TextCopy = "A : " + label11.Text +"R : "+ label8.Text + "G :" + label10.Text 
            //    + "B :" + label6.Text;
            //sb. = ;
            // Copy the label's text to the clipboard
            Clipboard.SetText(sb.ToString());

        }
    }
}
