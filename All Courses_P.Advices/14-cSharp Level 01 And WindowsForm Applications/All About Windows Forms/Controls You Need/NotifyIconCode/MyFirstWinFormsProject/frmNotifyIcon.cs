using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmNotifyIcon : Form
    {
        public frmNotifyIcon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "Notify";
            notifyIcon1.BalloonTipText = "New Notification";
            notifyIcon1.ShowBalloonTip(2000);

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            //MessageBox.Show("BalloonTip Clicked :-)");
            // You can Do any Thing You Want to Do Here
            System.Diagnostics.Process.Start("http://www.Gmail.com");
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            // When You Click one Close Button
            MessageBox.Show("BalloonTip Clicked :-)");
        }
    }
}
