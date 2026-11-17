using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Sample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
//        طريقة عمل القائمة لأكثر من عنصر:
//التابع الذي بالاسفل خاص بالزر ال كلير
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsm.Owner;
            cms.SourceControl.Text = "";
        }

//        شرح بسيط عال فهمته:

//sender
//, من وين اجى ؟ اجى من الضغط عالخيار الموجود بالقائمة يلي حطيتها لل تيكست بوكس
//القائمة هي عبارة عن
//ContextMenuStrip
//معناها العنصر الموجود فيها هو عبارة
//ToolStripMenuItem
//وهو نفس النوع ال
//sender

//فسوينا هيك
//ToolStripMenuItem tsm = (ToolStripMenuItem)sender;

//        هلق من خلال الكائن ال
//        tsm
//بروح بجيب القائمة من خلال الخاصية ال
//Owner

//فسوينا هيك:
//ContextMenuStrip cms = (ContextMenuStrip)tsm.Owner;

//        من خلال الكائن ال
//cms
//في خاصية اسمها
//SourceControl
//بتعطيني الكونترول يلي سبب بظهور هالقائمة وهو نفسه التيسكت بوكس بمثالنا


        private void tsmChangeColor_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsm.Owner;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cms.SourceControl.BackColor = colorDialog1.Color;
            }
        }
        
        private void tsmChangeFont_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsm.Owner;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                cms.SourceControl.Font = fontDialog1.Font;
                cms.SourceControl.ForeColor = fontDialog1.Color;

            }
        }

        private void tsmClear_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
            ContextMenuStrip cms = (ContextMenuStrip)tsm.Owner;
            cms.SourceControl.Text = "";
        }

        private void cmFormat_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Purple;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
