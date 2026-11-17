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
    public partial class frmLevel13 : Form
    {
        public frmLevel13(frmLevel12 lvl12)
        {
            InitializeComponent();
            _Level3 = lvl12;
        }

        private void frmLevel13_Load(object sender, EventArgs e)
        {
            _Level3.Hide();
        }
        private int StepNumber = 0;
        frmLevel12 _Level3;

        private void TurnButtonColorToBlueOnClick(Button Btn)
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
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            foreach (Control Ctrl in this.Controls)
            {
                if (Ctrl is Button Btn)
                {
                    if (Btn.Name == "btnReset" || Btn.Name == "btnNextLevel" || Btn.Name == "btnClose")
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
        private void buttonCloseOnClick(object sender, EventArgs e)
        {
            this.Close();
            _Level3.Show();
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            frmLevel14 lvl14 = new frmLevel14(this);
            lvl14.ShowDialog ();

        }
    }
}
