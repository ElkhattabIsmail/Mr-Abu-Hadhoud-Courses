using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace My_Own_Custom_Controls_library
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(Button))] // Use standard button icon

   
    public class CircularButton : Button
    {

        public CircularButton()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new System.Drawing.Size(70, 70);
            this.BackColor = Color.DarkGray;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            // Create a circular path
            using (GraphicsPath Gpath = new GraphicsPath())
            {
                Gpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

                this.Region = new System.Drawing.Region(Gpath);
            }
            base.OnPaint(e);
        }
     

    }
}
