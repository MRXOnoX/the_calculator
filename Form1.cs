using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void LTbutton_click(object sender, EventArgs e)
        {
            if ((LTtextBox_Result.Text == "0") || (isOperationPerformed))
                LTtextBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            { 
               if(!LTtextBox_Result.Text.Contains("."))
                   LTtextBox_Result.Text = LTtextBox_Result.Text + LTbutton.Text;

            }else
            LTtextBox_Result.Text = LTtextBox_Result.Text + LTbutton.Text;


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                LTbutton15.PerformClick();
                operationPerformed = button.Text;
                LTlabelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(LTtextBox_Result.Text);
                LTlabelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void LTbutton4_Click(object sender, EventArgs e)
        {
            LTtextBox_Result.Text = "0";
        }

        private void LTbutton5_Click(object sender, EventArgs e)
        {
            LTtextBox_Result.Text = "0";
            resultValue = 0;
        }

        private void LTbutton15_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    LTtextBox_Result.Text = (resultValue + Double.Parse(LTtextBox_Result.Text)).ToString();
                    break;
                case "-":
                    LTtextBox_Result.Text = (resultValue - Double.Parse(LTtextBox_Result.Text)).ToString();
                    break;
                case "*":
                    LTtextBox_Result.Text = (resultValue * Double.Parse(LTtextBox_Result.Text)).ToString();
                    break;
                case "/":
                    LTtextBox_Result.Text = (resultValue / Double.Parse(LTtextBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(LTtextBox_Result.Text);
            LTlabelCurrentOperation.Text = "";
        }
    }
}
