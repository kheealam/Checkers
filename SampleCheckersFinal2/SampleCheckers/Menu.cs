using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Width += 10;
            button1.Height += 10;
            button1.Left -= 5;
            //SoundPlayer leave = new SoundPlayer(@"D:\SampleCheckersFinal2\SampleCheckers\Resources\button-50.wav");
            //leave.Play();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Width -= 10;
            button1.Height -= 10;
            button1.Left += 5;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Width += 10;
            button2.Height += 10;
            button2.Left -= 5;
            //SoundPlayer leave = new SoundPlayer(@"D:\SampleCheckersFinal2\SampleCheckers\Resources\button-50.wav");
            //leave.Play();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Width -= 10;
            button2.Height -= 10;
            button2.Left += 5;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Width += 10;
            button3.Height += 10;
            button3.Left -= 5;
            //SoundPlayer leave = new SoundPlayer(@"D:\SampleCheckersFinal2\SampleCheckers\Resources\button-50.wav");
           // leave.Play();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Width -= 10;
            button3.Height -= 10;
            button3.Left += 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Names f3 = new Names();
            SoundPlayer enter = new SoundPlayer("button-30.wav");
           enter.Play();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer enter = new SoundPlayer("button-30.wav");
            enter.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer enter = new SoundPlayer("button-30.wav");
            enter.Play();
            Close();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Width -= 10;
            button1.Height -= 10;
            button1.Left += 5;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Width += 10;
            button1.Height += 10;
            button1.Left -= 5;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Width -= 10;
            button2.Height -= 10;
            button2.Left += 5;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Width += 10;
            button2.Height += 10;
            button2.Left -= 5;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.Width -= 10;
            button3.Height -= 10;
            button3.Left += 5;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.Width += 10;
            button3.Height += 10;
            button3.Left -= 5;
        }       
    }
}
