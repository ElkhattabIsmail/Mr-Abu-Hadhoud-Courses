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
    public partial class frmLevel3 : Form
    {
        
        public frmLevel3(frmLevel2 Level2)
        {
            InitializeComponent();
            _Level2 = Level2;
        }
        private frmLevel2 _Level2;
        private int StepNumber = 0;
       

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




        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
            _Level2.Show();
        }

        private void frmLevel3_Load(object sender, EventArgs e)
        {
            _Level2.Hide();
        }

        private void btnNextLevel_Click_1(object sender, EventArgs e)
        {
            frmLevel4 Level4 = new frmLevel4(this);
            Level4.ShowDialog();
        }
    }
}
