using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void disable()  //to disable calculator
        {
            testBox1.Enabled = false;
            button1.show();
            button2.Hide();
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;

        }

        public void enable()  //to disable calculator
        {
            testBox1.Enabled = true;
            button2.show();
            button1.Hide();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e) //off button
        {
            disable(); //Call Disable() function to OFF calculator
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //when enter it must be red color
            textBox1.Text = textBox1.Text + "9";
            textBox1.ForeColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //when enter it must be red color
            textBox1.Text = textBox1.Text + "4";
            textBox1.ForeColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //when enter it must be red color
            textBox1.Text = textBox1.Text + "5";
            textBox1.ForeColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //when enter it must be red color
            textBox1.Text = textBox1.Text + "3";
            textBox1.ForeColor = Color.Red;

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //when enter it must be red color
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Red;

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //when enter it must be red color
            textBox1.Text = textBox1.Text + "7";
            textBox1.ForeColor = Color.Red;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //when enter it must be red color
            textBox1.Text = textBox1.Text + "0";
            textBox1.ForeColor = Color.Red;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //when enter it must be red color
            textBox1.Text = textBox1.Text + "8";
            textBox1.ForeColor = Color.Red;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //when enter it must be red color
            textBox1.Text = textBox1.Text + "1";
            textBox1.ForeColor = Color.Red;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //when enter it must be red color
            textBox1.Text = textBox1.Text + "2";
            textBox1.ForeColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //when enter it must be red color
            textBox1.Text = textBox1.Text + "6";
            textBox1.ForeColor = Color.Red;
        }
    }
}
