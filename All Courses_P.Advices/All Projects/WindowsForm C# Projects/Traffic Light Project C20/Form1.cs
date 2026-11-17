using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light_Project_C20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Size = new Size(820, 820); // Set form size 
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Get the center of the form
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            // Define the road width and length
            int roadWidth = 60; // Width of the road
            int roadLength = 400; // Length of the road

            // Create a pen to draw the roads
            using (Pen roadPen = new Pen(Color.Black, roadWidth))
            {
                // Draw the vertical road (North-South)
                e.Graphics.DrawLine(roadPen, centerX, centerY - roadLength, centerX, centerY + roadLength);

                // Draw the horizontal road (East-West)
                e.Graphics.DrawLine(roadPen, centerX - roadLength, centerY, centerX + roadLength, centerY);
            }

            // Draw white dashed lines (lane markings) in the middle of the roads
            using (Pen whitePen = new Pen(Color.White, 4))
            {
                // Configure the pen to draw dashed lines
                whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                whitePen.DashPattern = new float[] { 10, 10 }; // Dash pattern: 10 pixels on, 10 pixels off

                // Draw the vertical dashed line (North-South)
                e.Graphics.DrawLine(whitePen, centerX, centerY - roadLength, centerX, centerY + roadLength);

                // Draw the horizontal dashed line (East-West)
                e.Graphics.DrawLine(whitePen, centerX - roadLength, centerY, centerX + roadLength, centerY);
            }
        }

        //  North-South Green → East-West Red
        //  North-South Orange/Yellow → East-West Red(waiting for transition)

        //  North-South Red → East-West Green

        //  East-West Green → North-South Red

        //  East-West Orange/Yellow → North-South Red(waiting for transition)

        //  East-West Red → North-South Green

        private void Form1_Load(object sender, EventArgs e)
        {
            StartTrafficLights();
        }
        private void StartTrafficLights()
        {
            ctrlTraficLight_Vertical_South.Start();
            ctrlTraficLight_Vertical_North.Start();
            ctrlTraficLight_Horizonatl_East.Start();
            ctrlTraficLight_Horizonatl_West.Start();
        }

        private void SetHorizontalLights(CtrlTraficLight.enTraficLightColors color)
        {
            ctrlTraficLight_Horizonatl_East.CurrentTraficColor = color;
            ctrlTraficLight_Horizonatl_West.CurrentTraficColor = color;

            ctrlTraficLight_Horizonatl_East.Start();
            ctrlTraficLight_Horizonatl_West.Start();
        }
        private void ctrlTraficLight_Vertical_South_RedLightOn(object sender, CtrlTraficLight.TraficLightEventArgs e)
        {
            // Change Vertical Horizonatl to Green
            SetHorizontalLights(CtrlTraficLight.enTraficLightColors.Green);
        }

        private void ctrlTraficLight_Vertical_South_OrangeLightOn(object sender, CtrlTraficLight.TraficLightEventArgs e)
        {
            // Change Horizonatl Trafics to Red
            SetHorizontalLights(CtrlTraficLight.enTraficLightColors.Red);
        }

        private void ctrlTraficLight_Vertical_South_GreenLightOn(object sender, CtrlTraficLight.TraficLightEventArgs e)
        {
            // Change Horizonatl Trafics to Red
            SetHorizontalLights(CtrlTraficLight.enTraficLightColors.Red);
        }
    }
}
