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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)   // Обработка нажатия цифр и их вывод на экран
        {
            if ((inputBox.Text == "0") || (isOperationPerformed))
                inputBox.Clear();

            Button button = (Button)sender;

            inputBox.Text = inputBox.Text + button.Text;
            isOperationPerformed = false;
        }

        private void operator_Click(object sender, EventArgs e) // Математические операции
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            result = Double.Parse(inputBox.Text);
            isOperationPerformed = true;
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
        }

    }
}
