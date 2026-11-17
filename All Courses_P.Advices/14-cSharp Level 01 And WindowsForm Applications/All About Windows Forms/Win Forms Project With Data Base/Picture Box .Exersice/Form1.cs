using Picture_Box.Exersice.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Picture_Box.Exersice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString().ToLower())
            {
                case "boy":
                    pictureBox1.Image = Resources.Boy;
                    label1.Text = "Boy";
                    break;
                case "girl":
                    pictureBox1.Image = Resources.Girl;
                    label1.Text = "Girl";
                    break;
                case "book":
                    pictureBox1.Image = Resources.Book;
                    label1.Text = "Book";
                    break;
                case "pen":
                    pictureBox1.Image = Resources.Pen;
                    label1.Text = "Pen";
                    break;
            }
            //if (comboBox1.SelectedIndex == 0)
            //{
            //    label1.Text = "Book";
            //    pictureBox1.Image = Resources.Book;
            //}
            //if (comboBox1.SelectedIndex == 1)
            //{
            //    label1.Text = "Boy";
            //    pictureBox1.Image = Resources.Boy;
            //}
            //if (comboBox1.SelectedIndex == 2)
            //{
            //    label1.Text = "Girl";
            //    pictureBox1.Image = Resources.Girl;
            //}
            //if (comboBox1.SelectedIndex == 3)
            //{
            //    label1.Text = "Pen";
            //    pictureBox1.Image = Resources.Pen;
            //}
        }




        //void UpdateImageAndTitle()
        //{

        //    if (rbBoy.Checked)
        //    {

        //        label1.Text = "Boy";
        //        pictureBox1.Image = Resources.Boy;
        //    }
        //    else if (rbGirl.Checked)
        //    {
        //        label1.Text = "Girl";
        //        pictureBox1.Image = Resources.Girl;
        //    }
        //    else if (rbPen.Checked)
        //    {

        //        label1.Text = "Pen";
        //        pictureBox1.Image = Resources.Pen;
        //    }
        //    else if (rbBook.Checked)
        //    {

        //  
        //    }

        //}
        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    UpdateImageAndTitle();
        //    // Or
        //    //label1.Text = "Boy";
        //    //pictureBox1.Image = Resources.Boy;
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    UpdateImageAndTitle();
        //    //label1.Text = "Girl";
        //    //pictureBox1.Image = Resources.Girl ;
        //}

        //private void radioButton3_CheckedChanged(object sender, EventArgs e)
        //{
        //    UpdateImageAndTitle();
        //    //label1.Text = "Book";
        //    //pictureBox1.Image = Resources.Book;
        //}

        //private void radioButton4_CheckedChanged(object sender, EventArgs e)
        //{
        //    UpdateImageAndTitle();
        //    //label1.Text = "Pen";
        //    //pictureBox1.Image = Resources.Pen;
        //}

    }
}
