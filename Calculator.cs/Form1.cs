using System;
using System.Windows.Forms;
using Calc.Models;

namespace Calc
{
    // Тък е главната форма на приложението.
    // Съдържа потребителския интерфейс и
    // логиката за връзка между User Interface и Calculator класа.
    public partial class Form1 : Form
    {
        // Създавам инстанция на класа Calculator, защото
        // така се отделя логиката от UI-а.
        
        private Calculator calc = new Calculator();

        // Конструктора на формата, който
        // Извиква InitializeComponent(), и той зарежда UI елементите.

        public Form1()
        {
            InitializeComponent();
        }

        // Извиква се метода Add() от Calculator и се показва
        // резултата в txtResult.

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /// Преобразувам тук стойностите от текстови към числов тип
            
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            /// Получаваме резултата и се показва
            txtResult.Text = calc.Add(a, b).ToString();
        }

        // Извиква метода Subtract() от Calculator.
        private void btnSub_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtResult.Text = calc.Subtract(a, b).ToString();
        }

        // Извиква се метода Multiply() от Calculator.
        private void btnMul_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            txtResult.Text = calc.Multiply(a, b).ToString();
        }

        //Проверява се за деление на нула и извиква метода Divide() от
        //Calculator.
        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            // Проверка за недопустима операция, като
            // съм го заложил само за делението
            if (b == 0)
            {
                MessageBox.Show("Не може да се дели на 0!");
                return;
            }

            txtResult.Text = calc.Divide(a, b).ToString();
        }
    }
}