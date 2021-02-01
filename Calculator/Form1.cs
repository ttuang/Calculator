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
        string input = string.Empty; //storing user input (string will handle chains of character
        string operand1 = string.Empty; //first storing operand
        string operand2 = string.Empty; //second storing operand
        char operation;                 //char for operation (C,*,+,-,/)
        double result = 0.0;            //calculate result (double will hold value with decimal 1.4)
        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";        //ths will clears the TextBox before the input string is added
            input += "0";                   //add zero to the input character string
            this.textBox1.Text += input;    //add the input to the TextBox 
        }

        private void dot_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            operand2 = input;   //assuming user click has click
            double num1, num2;  //store numerical values from operand1 and 2
            double.TryParse(operand1, out num1); //convert the string that is in operand1, into a double type and place it in num1 or num2
            double.TryParse(operand2, out num2);

            this.textBox1.Text = "";
            this.input = string.Empty; //storing user input
            this.operand1 = string.Empty; //first storing operand
            this.operand2 = string.Empty; //second storing operand

            if (operation == '+')
            {
                result = num1 + num2;   //add vairables num1 and 2 and store the result
                textBox1.Text = result.ToString(); //convert the result variable to a string type and display the output in the TextBox
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Division/0!";
                }
            }

        }
    
        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            // storing the contents of the input string into the operand1 stirng
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";        // clears the textbox
            this.input = string.Empty;      // empty input
            this.operand1 = string.Empty;   // empty input operand1
            this.operand2 = string.Empty;   // empty input eprand2
        }
    }
}