//Author: RUtviben Shah
//Date: July 4,2018
//Time: 4:00 P.M
//Aim: To create a basic calculator.

using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Calculator : Form
    {
        //Defining a variable 
        private string displayValue;
        private double currentValue;
        private double opr1;
        private double opr2; 
        private bool equalsPressed;

        private enum Operator { Addition, Subtraction, Multiplication, Division, None };
        private Operator op;
        
        //Constructor
        public Calculator()
        {
            InitializeComponent();
            op = Operator.None;
            equalsPressed = true;
        }

        //-----------------------------------------ALL BUTTON CLICK EVENTS-----------------------------------


        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" && tbResult.Text != null)
            {
                tbResult.Text = "0";
            }
            else
            {
                tbResult.Text = tbResult.Text + "0";
            }

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" && tbResult.Text != null)
            {
                tbResult.Text = "1";
            }
            else
            {
                tbResult.Text = tbResult.Text + "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" && tbResult.Text != null)
            {
                tbResult.Text = "2";

            }
            else
            {
                tbResult.Text = tbResult.Text + "2";
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" && tbResult.Text != null)
            {
                tbResult.Text = "3";

            }
            else
            {
                tbResult.Text = tbResult.Text + "3";

            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" && tbResult.Text != null)
            {
                tbResult.Text = "4";
            }
            else
            {
                tbResult.Text = tbResult.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" && tbResult.Text != null)
            {
                tbResult.Text = "5";

            }
            else
            {
                tbResult.Text = tbResult.Text + "5";

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" && tbResult.Text != null)
            {
                tbResult.Text = "6";

            }
            else
            {
                tbResult.Text = tbResult.Text + "6";

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" && tbResult.Text != null)
            {
                tbResult.Text = "7";

            }
            else
            {
                tbResult.Text = tbResult.Text + "7";

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" && tbResult.Text != null)
            {
                tbResult.Text = "8";
            }
            else
            {
                tbResult.Text = tbResult.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" && tbResult.Text != null)
            {
                tbResult.Text = "9";
            }
            else
            {
                tbResult.Text = tbResult.Text + "9";
            }
        }
        //Clear click event which will clear all the data and reset the calculator
        public void Clear()
        {
            tbResult.Text = "0";
            currentValue = 0;
            displayValue =" 0";
            op = Operator.None;
            lblMessage.Text = "";
            opr1 = 0;
            opr2 = 0;
        }

        //'+' Click event
        private void btnPlus_Click(object sender, EventArgs e)
        {            
            double.TryParse(tbResult.Text, out opr1);
            tbResult.Text = "";
            op = Operator.Addition;
            lblMessage.Text = opr1.ToString() + " + ";
            equalsPressed = true;
        }

        //'/' Click event
        private void btnDivision_Click(object sender, EventArgs e)
        {
            double.TryParse(tbResult.Text, out opr1);
            tbResult.Text = "";
            op = Operator.Division;
            lblMessage.Text = opr1.ToString() + " / ";
            equalsPressed = true;
        }

        //'*' Click event
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            double.TryParse(tbResult.Text, out opr1);
            tbResult.Text = "";
            op = Operator.Multiplication;
            lblMessage.Text = opr1.ToString() + " * ";
            equalsPressed = true;
        }

        //'-' Click event
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double.TryParse(tbResult.Text, out opr1);
            tbResult.Text = "";
            op = Operator.Subtraction;
            lblMessage.Text = opr1.ToString() + " - ";
            equalsPressed = true;
        }

        //'Backspace' event 
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tbResult.Text.Length > 0)
            {
                tbResult.Text = tbResult.Text.Remove(tbResult.Text.Length - 1);
            }
        }

        //'Clear' event
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();

        }
        //'CE' event
        private void btnCE_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        //'=' event
        private void btnEquals_Click(object sender, EventArgs e)
        {
            this.Equals();
        
        }

        //'+/-' event which will replace the sign
        private void btnPlusOrMinus_Click(object sender, EventArgs e)
        {           
            double.TryParse(tbResult.Text, out opr1);
            tbResult.Text = (-opr1).ToString();
            opr1 = -opr1;
            tbResult.Text = opr1.ToString();            
        }

        //'.' event
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!tbResult.Text.Contains("."))
            {
                tbResult.Text = tbResult.Text + ".";
            }
            else
            {
                tbResult.Text = tbResult.Text;
            }
        }

        //SQRT event
        private void btnSqrt_Click(object sender, EventArgs e)
        {            
            if (double.TryParse(tbResult.Text, out opr1))
            {
                tbResult.Text = (Math.Sqrt(opr1)).ToString();
                lblMessage.Text = "\u221A"+tbResult.Text ;
            }
        }

        //Divide by X 
        private void btnOnebyX_Click(object sender, EventArgs e)
        {
           
            if (double.TryParse(tbResult.Text, out opr1))
            {
                tbResult.Text = (1 / opr1).ToString();
                lblMessage.Text = tbResult.Text + "/x";
            }
        }

        //--------------------------------------METHODS Which will implement all add,sub,div and mul functionality.----------------------------------------------
        //ADD Method 
        public void Add(string displayValue)
        {
            double.TryParse(displayValue, out currentValue);
            if (equalsPressed == false)
            {
                opr1 = currentValue + opr2;
                lblMessage.Text = opr1.ToString() + "+" + opr2.ToString()+"=";
            }
            else
            {
                opr2 = currentValue;
                lblMessage.Text = opr1.ToString() + " + " + opr2.ToString() + " = ";
                // Performing Operation On Operand1 And CurrentValue.
                opr1 = opr1 + currentValue;
                equalsPressed = false;
            }                       
        }
       
        //Subtraction
        public void Sub(string displayValue)
        {
            double.TryParse(displayValue, out currentValue);
            if (equalsPressed == false)
            {
                opr1 = currentValue - opr2;
                lblMessage.Text = opr1.ToString() + "-" + opr2.ToString() + "=";
            }
            else
            {
                opr2 = currentValue;
                lblMessage.Text = opr1.ToString() + " - " + opr2.ToString() + " = ";
                // Performing Operation On Operand1 And CurrentValue.
                opr1 = opr1 - currentValue;
                equalsPressed = false;
            }
        }

        //Mutiplication
        public void Mul(string displayValue)
        {
            double.TryParse(displayValue, out currentValue);
            if (equalsPressed == false)
            {
                lblMessage.Text = opr1.ToString() + "*" + opr2.ToString() + "=";
                opr1 = currentValue * opr2;
            }
            else
            {
                opr2 = currentValue;
                lblMessage.Text = opr1.ToString() + " * " + opr2.ToString() + " = ";
                // Performing Operation On Operand1 And CurrentValue.
                opr1 = opr1 * currentValue;
                equalsPressed = false;
            }
        }

        //Division : Check the operan2not equal to zero if it is then throws an exception
        public void Div(string displayValue)
        {
            double.TryParse(displayValue, out currentValue);
            try
            {
                if (equalsPressed == false)
                {
                    // Explicitly Throwing Error If Denominator Is Zero.
                    if (opr2 != 0)
                    {
                        lblMessage.Text = opr1.ToString() + " / " + opr2.ToString() + " = ";
                        opr1 = currentValue / opr2;
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }
                }
                else
                {
                    if (currentValue != 0)
                    {
                        opr2 = currentValue;
                        lblMessage.Text = opr1.ToString() + " / " + opr2.ToString() + " = ";
                        opr1 = opr1 / currentValue;
                        equalsPressed = false;
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }
                }
            }
            catch (DivideByZeroException)
            {
                // Resetting Everything And Displaying Error.
                btnClear.PerformClick();
                lblMessage.Text = "ERROR You can not divide by Zero";
            }
        }
        //Switch for equal according to enum index it will perform the operation
        public void Equals()
        {
            string data = tbResult.Text;
            switch ((int)op)
            {
                case 0:
                    {
                        //Call the add method
                        Add(data);
                        break;
                    }
                case 1:
                    {
                        //Call the Sub method
                        Sub(data);
                        break;
                    }
                case 2:
                    {
                        //call the multiplication method
                        Mul(data);
                        break;
                    }
                case 3:
                    {
                        //call div method
                        Div(data);
                        break;
                    }
            }              
            tbResult.Text = opr1.ToString();
        }

        //--------------------ALL Key Press Events---------------------------------
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    btn9.PerformClick();
                    break;
                case Keys.Add:
                    btnPlus.PerformClick(); break;
                case Keys.Subtract:
                    btnSubtract.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMultiplication.PerformClick();
                    break;
                case Keys.Divide:
                    btnDivision.PerformClick();
                    break;
                case Keys.Enter:
                    btnEquals.PerformClick();
                    break;
                case Keys.Oemplus:
                    btnEquals.PerformClick();
                    break;
                case Keys.Back:
                    btnBack.PerformClick();
                    break;
                default:
                    break;
            }
        }        
    }
}
