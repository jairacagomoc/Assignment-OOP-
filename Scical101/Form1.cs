using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scical101
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operation = "";
        bool isOperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || (isOperation))
                textBox1_Result.Clear();
                isOperation = false;
                Button button = (Button)sender;

            //for repeating dots//
            if (button.Text==".")
            {
                if (!textBox1_Result.Text.Contains("."))
                    textBox1_Result.Text = textBox1_Result.Text + button.Text;
            }
            else
            textBox1_Result.Text = textBox1_Result.Text + button.Text;
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
            labelOperation.Text = "";
        }

       
        private void DelButton_Click(object sender, EventArgs e)
        {
            if (textBox1_Result.Text.Length>0)
            {
                textBox1_Result.Text = textBox1_Result.Text.Remove(textBox1_Result.Text.Length - 1, 1);
            }
            if (textBox1_Result.Text=="")
            {
                textBox1_Result.Text = "0";
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || (isOperation))
                textBox1_Result.Clear();

            isOperation = false;
            Button button = (Button)sender;
                textBox1_Result.Text = textBox1_Result.Text + " 3.14159 ";
        }

        private void Operation_Button(object sender, EventArgs e)
        {
            Button button = (Button)sender;
                operation = button.Text;
                resultValue = Double.Parse(textBox1_Result.Text);
                textBox1_Result.Text = "";
                labelOperation.Text = System.Convert.ToString(resultValue) + "  " + operation;
                isOperation = true;
            }
        }

        private void Equal_Button(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1_Result.Text = (resultValue + Double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "-":
                    textBox1_Result.Text = (resultValue - Double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "*":
                    textBox1_Result.Text = (resultValue * Double.Parse(textBox1_Result.Text)).ToString();
                    break;
                case "/":
                    textBox1_Result.Text = (resultValue / Double.Parse(textBox1_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
