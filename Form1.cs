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
    public partial class Calculator : Form
    {
        string first = "";
        string second = "";
        string userInput = "";
        char function;
        double res = 0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resField.Text = "";
            userInput += "1";
            resField.Text += userInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resField.Text = "";
            userInput += "2";
            resField.Text += userInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resField.Text = "";
            userInput += "3";
            resField.Text += userInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resField.Text = "";
            userInput += "4";
            resField.Text += userInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resField.Text = "";
            userInput += "5";
            resField.Text += userInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resField.Text = "";
            userInput += "6";
            resField.Text += userInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resField.Text = "";
            userInput += "7";
            resField.Text += userInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resField.Text = "";
            userInput += "8";
            resField.Text += userInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resField.Text = "";
            userInput += "9";
            resField.Text += userInput;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            resField.Text = "";
            userInput += "0";
            resField.Text += userInput;
        }

        private void virgulButton_Click(object sender, EventArgs e)
        {
            resField.Text = "";
            resField.Text += ",";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            res = 0.0;
            resField.Text = "0";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void susButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void egalButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if (function == '+')//add
            {
                res = firstNum + secondNum;
                resField.Text = res.ToString();
            }else if (function == '-')//sus
            {
                res = firstNum - secondNum;
                resField.Text = res.ToString();
            }
            else if(function == '/')//div
            {
                if(secondNum == '0')
                {
                    resField.Text = "Impossible to divide by 0";
                }
                else
                {
                    res = firstNum / secondNum;
                    resField.Text = res.ToString();
                }
            }
            else if (function == '*')//multi
            {
                res = firstNum * secondNum;
                resField.Text = res.ToString();
            }
        }
    }
}
