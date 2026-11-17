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
    public partial class frmLevel12 : Form
    {
        public frmLevel12(frmLevel11 lvl11)
        {
            InitializeComponent();
            _Level3 = lvl11;
        }

        private int StepNumber = 0;
        frmLevel11 _Level3;

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



        private void frmLevel5_Load_1(object sender, EventArgs e)
        {
            _Level3.Hide();
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            frmLevel13 lvl13 = new frmLevel13(this);
            lvl13.ShowDialog();
        }
    }
}
