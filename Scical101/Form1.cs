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

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void EqualButton_Click(object sender, EventArgs e)
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1_Result.Text);
            labelOperation.Text = System.Convert.ToString("Log" + "(" + (textBox1_Result.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1_Result.Text = System.Convert.ToString(ilog);
            
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(textBox1_Result.Text);
            labelOperation.Text = System.Convert.ToString("Sqrt" + "(" + (textBox1_Result.Text) + ")");
            sq = Math.Sqrt(sq);
            textBox1_Result.Text = System.Convert.ToString(sq);
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            double  sin= Double.Parse(textBox1_Result.Text);
            labelOperation.Text = System.Convert.ToString("Sin" + "(" + (textBox1_Result.Text) + ")");
            sin = Math.Sin(sin);
            textBox1_Result.Text = System.Convert.ToString(sin);
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(textBox1_Result.Text);
            labelOperation.Text = System.Convert.ToString("Cos" + "(" + (textBox1_Result.Text) + ")");
            cos = Math.Cos(cos);
            textBox1_Result.Text = System.Convert.ToString(cos);
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(textBox1_Result.Text);
            labelOperation.Text = System.Convert.ToString("Tan" + "(" + (textBox1_Result.Text) + ")");
            tan = Math.Tan(tan);
            textBox1_Result.Text = System.Convert.ToString(tan);
        }

        private void ln_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1_Result.Text);
            labelOperation.Text = System.Convert.ToString("Log" + "(" + (textBox1_Result.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1_Result.Text = System.Convert.ToString(ilog);
        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            double qsinh = Double.Parse(textBox1_Result.Text);
            labelOperation.Text = System.Convert.ToString("Sinh" + "(" + (textBox1_Result.Text) + ")");
            qsinh = Math.Sinh(qsinh);
            textBox1_Result.Text = System.Convert.ToString(qsinh);
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            double qcosh = Double.Parse(textBox1_Result.Text);
            labelOperation.Text = System.Convert.ToString("Cosh" + "(" + (textBox1_Result.Text) + ")");
            qcosh = Math.Cosh(qcosh);
            textBox1_Result.Text = System.Convert.ToString(qcosh);
        }

        private void Tanh_Click(object sender, EventArgs e)
        {
            double qtanh = Double.Parse(textBox1_Result.Text);
            labelOperation.Text = System.Convert.ToString("Tanh" + "(" + (textBox1_Result.Text) + ")");
            qtanh = Math.Tanh(qtanh);
            textBox1_Result.Text = System.Convert.ToString(qtanh);
        }

        private void Btnx2_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1_Result.Text) * Convert.ToDouble(textBox1_Result.Text);
            textBox1_Result.Text = System.Convert.ToString(a);
        }

        private void Btnx3_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1_Result.Text) * Convert.ToDouble(textBox1_Result.Text) * Convert.ToDouble(textBox1_Result.Text);
            textBox1_Result.Text = System.Convert.ToString(a);
        }

        private void Btnbin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1_Result.Text);
            textBox1_Result.Text = System.Convert.ToString(a, 2);
        }

        private void Btnhex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1_Result.Text);
            textBox1_Result.Text = System.Convert.ToString(a, 16);
        }
    }

}
