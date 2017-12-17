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
    public partial class mainForm : Form
    {
        Double result = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public mainForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)   // Обработка нажатия цифр и их вывод на экран
        {

            if ((inputBox.Text == "0") || (isOperationPerformed))
                inputBox.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;

            inputBox.Text = inputBox.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e) // Математические операции
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                buttonResult.PerformClick();
                operationPerformed = button.Text;
                label.Text = result + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                result = Double.Parse(inputBox.Text);
                label.Text = result + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void buttonResult_Click(object sender, EventArgs e) // Подсчет результата
        {
            switch (operationPerformed)
            {
                case "+":
                    inputBox.Text = (result + Double.Parse(inputBox.Text)).ToString();
                    break;
                case "-":
                    inputBox.Text = (result - Double.Parse(inputBox.Text)).ToString();
                    break;
                case "*":
                    inputBox.Text = (result * Double.Parse(inputBox.Text)).ToString();
                    break;
                case "/":
                    inputBox.Text = (result / Double.Parse(inputBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            operationPerformed = "0";
            result = Double.Parse(inputBox.Text);
            label.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)     // сброс значений
        {
            inputBox.Text = "0";
            result = 0;
        }

    }
}
