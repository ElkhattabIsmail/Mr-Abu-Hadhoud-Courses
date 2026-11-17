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
    public partial class frmLevel2 : Form
    {
        private int StepNumber = 0;

        private Form1 frm1;
        public frmLevel2(Form1 frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
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

        private void frmLevel2_Load(object sender, EventArgs e)
        {
            frm1.Hide();
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            frmLevel3 Level3 = new frmLevel3(this);
            Level3.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
            frm1.Show();
            
        }
    }
}
