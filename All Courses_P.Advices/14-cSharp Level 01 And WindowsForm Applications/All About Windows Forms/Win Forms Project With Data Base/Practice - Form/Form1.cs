using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice___Form
{
    public partial class Practice : Form
    {
        public Practice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FirstNameBox.Text == "")
            {
                FirstNameBox.BackColor = Color.Red;
            }
            else if (LastNameBox.Text == "")
            {
                LastNameBox.BackColor = Color.Red;
            }
            else if (Emailbox.Text == "")
            {
                Emailbox.BackColor = Color.Red;
            }
            else if (Addressbox.Text == "")
            {
                Addressbox.BackColor = Color.Red;
            }
            else if (PassBox.Text == "")
            {
                PassBox.BackColor =  Color.Red;
            }
            else if (PassBox.Text.Length < 8)
            {
                Alert.Visible = true;
                Alert.Text = "Password very Short\nmust be 8 Chars at least";
                PassBox.Text = "";
                PassBox.BackColor = Color.Red;
            }
            else
            {
                Alert.Visible = false;
                button2_Click(sender, e);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label8.Text = "Login Form";
            label8.TextAlign = ContentAlignment.TopCenter;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            FirstNameBox.Visible = false;
            LastNameBox.Visible = false;
            Addressbox.Visible = false;
            Emailbox.Visible = false;
            PassBox.Visible = false;
            button1.Visible = false;
            pictureBox1.Visible = false;
            AlreadyHaveaAnAccount.Visible = false;
            label9.Visible = true;
            label10.Visible = true;
            textBox6.Visible =  true;
            textBox7.Visible =  true;
            LoginButton.Visible = true;



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
             PassBox.Tag = PassBox.Text;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Emailbox.Tag = Emailbox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form frm1 = new AnotherForm();
            frm1.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
