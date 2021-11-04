using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Clear();
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Clear();
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void triogonometry_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Clear();
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void shift_Click(object sender, EventArgs e)
        {

        }

        private void hyp_click(object sender, EventArgs e)
        {

        }

        private void open_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Clear();
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void close_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Clear();
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void function_click(object sender, EventArgs e)
        {

        }

        private void factorial_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Clear();
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void naturallog_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Clear();
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void constant_click(object sender, EventArgs e)
        {

        }

        private void exp_click(object sender, EventArgs e)
        {

        }

        private void pie_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Clear();
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + " 3.14159 ";
        }

        private void log_click(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Clear();
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void equal_click(object sender, EventArgs e)
        {
            
        }

        private void memorystore_click(object sender, EventArgs e)
        {

        }

        private void memoryrecall_click(object sender, EventArgs e)
        {

        }

        private void memoryclearall_click(object sender, EventArgs e)
        {

        }

        private void memoryadd_click(object sender, EventArgs e)
        {

        }

        private void memorysubtract_click(object sender, EventArgs e)
        {

        }

        private void clear_click(object sender, EventArgs e)
        {

        }

        private void delete_click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
    

