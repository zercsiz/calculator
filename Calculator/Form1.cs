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
    public partial class Form1: Form
    {
        char[] OP_LIST = {'+', '-' ,'÷' ,'×'};
        double a;
        double b;
        char operation = '\0';
        double result;
        public Form1()
        {
            InitializeComponent();
            input.MaxLength = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input.Text += '7';

        }

        private void button9_Click(object sender, EventArgs e)
        {
            input.Text += '8';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input.Text += '9';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(input.Text != "0")
            {
                input.Text += '0';

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(!input.Text.Contains('.')){
                input.Text += '.';
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(input.Text != "")
            {
                a = 0;
                b = 0;
                operation = '\0';
                input.Clear();
                label1.Text = "";
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = double.Parse(input.Text);
            label1.Text = Convert.ToString(a);
            label1.Text += " + ";
            input.Clear();
            operation = '+';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = double.Parse(input.Text);
            label1.Text = Convert.ToString(a);
            label1.Text += " - ";
            input.Clear();
            operation = '-';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = double.Parse(input.Text);
            label1.Text = Convert.ToString(a);
            label1.Text += " × ";
            input.Clear();
            operation = '*';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = double.Parse(input.Text);
            label1.Text = Convert.ToString(a);
            label1.Text += " ÷ ";
            input.Clear();
            operation = '/';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = double.Parse(input.Text);
            label1.Text = Convert.ToString(a);
            label1.Text += " ^ ";
            input.Clear();
            operation = '^';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (input.Text.Length > 0)
            {
                string modified = input.Text.Remove(input.Text.Length - 1);
                input.Text = modified;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case '+':
                    b = double.Parse(input.Text);
                    label1.Text += Convert.ToString(b);
                    label1.Text += " = ";
                    result = a + b;
                    input.Text = Convert.ToString(result);
                    break;

                case '-':
                    b = double.Parse(input.Text);
                    label1.Text += Convert.ToString(b);
                    label1.Text += " = ";
                    result = a - b;
                    input.Text = Convert.ToString(result);
                    break;

                case '*':
                    b = double.Parse(input.Text);
                    label1.Text += Convert.ToString(b);
                    label1.Text += " = ";
                    result = a * b;
                    input.Text = Convert.ToString(result);
                    break;

                case '/':
                    if(input.Text !="0" && input.Text != "")
                    {
                        b = double.Parse(input.Text);
                        label1.Text += Convert.ToString(b);
                        label1.Text += " = ";
                        result = a / b;
                        input.Text = Convert.ToString(result);
                    }
                    break;


                case '^':
                    b = double.Parse(input.Text);
                    label1.Text += Convert.ToString(b);
                    label1.Text += " = ";
                    result = Math.Pow(a, b);
                    input.Text = Convert.ToString(result);
                    break;


            }
        }
    }
}
