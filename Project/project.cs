using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Project
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

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "7";
            richTextBox1.Text = richTextBox1.Text + button2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "1";
            richTextBox1.Text = richTextBox1.Text + button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "2";
            richTextBox1.Text = richTextBox1.Text + button8.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "3";
            richTextBox1.Text = richTextBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = "0";
            richTextBox1.Text = richTextBox1.Text + button11.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "4";
            richTextBox1.Text = richTextBox1.Text + button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "5";
            richTextBox1.Text = richTextBox1.Text + button5.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "6";
            richTextBox1.Text = richTextBox1.Text + button7.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "8";
            richTextBox1.Text = richTextBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "9";
            richTextBox1.Text = richTextBox1.Text + button4.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
