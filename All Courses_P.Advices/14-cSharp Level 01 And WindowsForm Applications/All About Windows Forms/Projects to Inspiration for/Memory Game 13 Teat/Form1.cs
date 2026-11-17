using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game_13_Teat
{
    public partial class Form1 : Form
    {
        private int StepNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void TurnButtonColorToBlueOnClick(Button  Btn)
        {
            Btn.BackColor = Color.DeepSkyBlue;
            if (Btn.Text == "")
            {
                Btn.Text = (StepNumber += 1).ToString();
            }
        }
        private void ChangeButtonBackColorOnClick(object sender, EventArgs e)
        {
            TurnButtonColorToBlueOnClick((Button)sender);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control Ctrl in this.Controls)
            {
                if (Ctrl is Button Btn)
                {
                    if (Btn.Name == "btnReset" || Btn.Name == "btnNextLevel")
                    {
                        continue;
                    }
                    Btn.BackColor = Color.White;
                    Btn.Text = "";
                }
                // Reset Steps
                StepNumber = 0;
            }
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            frmLevel2 Level2 = new frmLevel2(this);
            Level2.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this .Close();
        }
    }
}
