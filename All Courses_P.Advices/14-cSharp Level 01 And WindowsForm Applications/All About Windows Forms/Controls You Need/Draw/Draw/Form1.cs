using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ////Color Black = Color.FromArgb(255, 0, 0, 0); // set color
            Color Black = Color.Black; // set color


            Pen Pen = new Pen(Black); // assign pen var and give it the clr

            Pen.Width = 15; // line width

           // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;

            // drawing lib           X     Y    XF   YF
            e.Graphics.DrawLine(Pen, 110, 110, 110, 210);

            e.Graphics.DrawLine(Pen, 100, 100, 100, 200);
            e.Graphics.DrawRectangle(Pen,200, 200,300,300);
            e.Graphics.DrawEllipse(Pen, 200, 50, 50, 50);  // W AND LEN
        }
    }
}
