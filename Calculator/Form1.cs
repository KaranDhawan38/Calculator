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
        public Calculator()
        {
            InitializeComponent();
            Number1.Text = "";
            Number2.Text = "";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            Operation.Text = "+";
            Number1.Text = "0";
            Number2.Text = "0";
            Result.Text = "= 0";
            Add.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum;
            Operation.Text = "+";
            if (Number1.Text != "" && Number2.Text != "" && Number1.Text != "-" && Number2.Text != "-")
            {
                firstNum = double.Parse(Number1.Text);
                secondNum = double.Parse(Number2.Text);
                Result.Text = "= " + (firstNum + secondNum).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum;
            Operation.Text = "%";
            if (Number1.Text != "" && Number2.Text != "" && Number1.Text != "-" && Number2.Text != "-")
            {
                firstNum = double.Parse(Number1.Text);
                secondNum = double.Parse(Number2.Text);
                Result.Text = "= " + (firstNum % secondNum).ToString();
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum;
            Operation.Text = "*";
            if (Number1.Text != "" && Number2.Text != "" && Number1.Text != "-" && Number2.Text != "-")
            {
                firstNum = double.Parse(Number1.Text);
                secondNum = double.Parse(Number2.Text);
                Result.Text = "= " + (firstNum * secondNum).ToString();
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum;
            Operation.Text = "-";
            if (Number1.Text != "" && Number2.Text != "" && Number1.Text != "-" && Number2.Text != "-")
            {
                firstNum = double.Parse(Number1.Text);
                secondNum = double.Parse(Number2.Text);
                Result.Text = "= " + (firstNum - secondNum).ToString();
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum;
            Operation.Text = "/";
            if (Number1.Text != "" && Number2.Text != "" && Number1.Text != "-" && Number2.Text != "-")
            {
                firstNum = double.Parse(Number1.Text);
                secondNum = double.Parse(Number2.Text);
                Result.Text = "= " + (firstNum / secondNum).ToString();
            }
        }

        private void Number1_KeyUp(object sender, KeyEventArgs e)
        {
            autoCalculate();
        }

        private void Number2_KeyUp(object sender, KeyEventArgs e)
        {
            autoCalculate();
        }

        private void Number1_TextChanged_1(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder(Number1.Text);
            string newStr = removeUnnecessaryCharacters(str);
            Number1.Text = newStr;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder(Number2.Text);
            string newStr = removeUnnecessaryCharacters(str);
            Number2.Text = newStr;
        }

        private string removeUnnecessaryCharacters(StringBuilder str)
        {
            string newStr = "";
            int decimalFlag = 0;
            for (int i = 0; i < str.Length; i++)
            {
                //// Remove anything other than numbers /////////////
                if (str[i] == '0' || str[i] == '1' || str[i] == '2' || str[i] == '3' || str[i] == '4' || str[i] == '5' || str[i] == '6' || str[i] == '7' || str[i] == '8' || str[i] == '9')
                    newStr += str[i];
                //// Minus sign can only come in front of the number /////////////
                else if (str[i] == '-')
                {
                    if (i == 0)
                        newStr += str[i];
                    else if (str[i - 1] != '0' && str[i - 1] != '1' && str[i - 1] != '2' && str[i - 1] != '3' && str[i - 1] != '4' && str[i - 1] != '5' && str[i - 1] != '6' && str[i - 1] != '7' && str[i - 1] != '8' && str[i - 1] != '9' && str[i - 1] != '.' && str[i - 1] != '-')
                        newStr += str[i];
                }
                //// Decimal can only come once /////////////
                else if(i!=0 && decimalFlag==0 && str[i] == '.')
                {
                    newStr += str[i];
                    decimalFlag = 1;
                }
            }
            return newStr;
        }

        private void autoCalculate()
        {
            //// This function performs automatic calculations when a number is changed in input //////
            if (Operation.Text == "+")
                Add.PerformClick();
            else if (Operation.Text == "*")
                Multiply.PerformClick();
            else if (Operation.Text == "-")
                Minus.PerformClick();
            else if (Operation.Text == "/")
                Divide.PerformClick();
            else
                Modulus.PerformClick();
        }

    }
}
