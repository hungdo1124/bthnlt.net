using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        private string operatorUsed;
        private double firstOperand;
        private bool isOperatorClicked;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            operatorUsed = string.Empty;
            firstOperand = 0;
            isOperatorClicked = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBox_Result.Text == "0" || isOperatorClicked)
                textBox_Result.Clear();

            isOperatorClicked = false;
            textBox_Result.Text += button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            firstOperand = Double.Parse(textBox_Result.Text);
            operatorUsed = button.Text;
            isOperatorClicked = true;
        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            double secondOperand = Double.Parse(textBox_Result.Text);
            double result = 0;

            switch (operatorUsed)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    break;
                case "-":
                    result = firstOperand - secondOperand;
                    break;
                case "*":
                    result = firstOperand * secondOperand;
                    break;
                case "/":
                    result = firstOperand / secondOperand;
                    break;
            }

            textBox_Result.Text = result.ToString();
            operatorUsed = string.Empty;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            firstOperand = 0;
            operatorUsed = string.Empty;
        }
    }
}
