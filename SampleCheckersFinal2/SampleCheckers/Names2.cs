using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Names : Form
    {
        public Names()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("You Must Enter the Name", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Select Mode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    f1.label2.Text = textBox1.Text;
                    f1.Show();
                    this.Hide();
                }
            }
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("You Must Enter the Name(s)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //else if (radioButton1.Checked == false && radioButton2.Checked == false)
                //{
                //    MessageBox.Show("Select Mode ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                else
                {
                    f1.label2.Text = textBox1.Text;
                    f1.label1.Text = textBox2.Text;
                    f1.Show();
                    this.Hide();
                }
            }     
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox2.Enabled = false;
                textBox2.BackColor = Color.Gray;
                textBox2.Text = "Computer";
                f1.label1.Text = "Computer";
            }
            else if (radioButton1.Checked == false)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.BackColor = Color.White;;
            }
        }
    }
}