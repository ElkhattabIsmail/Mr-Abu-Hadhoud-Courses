using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Build_Your_Own_Control
{
    public partial class SimpleCalculator : UserControl
    {public SimpleCalculator()
        {
            InitializeComponent();
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
            label3.Text = (float.Parse(textBox1.Text) + float.Parse(textBox2.Text)).ToString();
        }
    }
}
