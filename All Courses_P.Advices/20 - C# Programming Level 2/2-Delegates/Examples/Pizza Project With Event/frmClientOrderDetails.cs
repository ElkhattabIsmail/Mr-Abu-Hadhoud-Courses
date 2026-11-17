using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaArgs
{
    public partial class frmClientOrderDetails : Form
    {
        public frmClientOrderDetails()
        {
            InitializeComponent();
        }
        public void SubscribeToEvent(Form1 frm1)
        {
            frm1.OnPizzaOrderCreated += HandlePizzaOrder;
        }
        // This method will handle the event and update the UI
        private void HandlePizzaOrder(object sender, PizzaOrderEventArgs e)
        {
            lblSize.Text = e.Size.ToString();
            lblNum.Text = e.Count.ToString();
            lblTotalPrice.Text = e.TotalPrice.ToString();
        }
    }
}
