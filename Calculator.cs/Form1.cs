using System;
using System.Windows.Forms;
using Calc.Models;

namespace Calc
{
    // This is the main form of the application.
    // It contains the user interface and
    // the logic that connects the User Interface with the Calculator class.
    public partial class Form1 : Form
    {
        // Creating an instance of the Calculator class because
        // this way the logic is separated from the UI.
        private Calculator calc = new Calculator();

        // The constructor of the form, which
        // calls InitializeComponent(), and it loads the UI elements.
        public Form1()
        {
            InitializeComponent();
        }

        // Calls the Add() method from Calculator and displays
        // the result in txtResult.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /// Converting the values here from text type to numeric type
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            /// Getting the result and displaying it
            txtResult.Text = calc.Add(a, b).ToString();
        }

        // Calls the Subtract() method from Calculator.
        private void btnSub_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtResult.Text = calc.Subtract(a, b).ToString();
        }

        // Calls the Multiply() method from Calculator.
        private void btnMul_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtResult.Text = calc.Multiply(a, b).ToString();
        }

        // Checks for division by zero and calls the Divide() method from
        // Calculator.
        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            // A check for an invalid operation,
            // which I have applied only for division.
            if (b == 0)
            {
                MessageBox.Show("Cannot divide by 0!");
                return;
            }

            txtResult.Text = calc.Divide(a, b).ToString();
        }
    }
}
