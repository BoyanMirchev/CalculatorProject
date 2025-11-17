
// Author: Boyan Angelov Mirchev
// Faculty number: F113037
// File: Calculator.cs
// Description: A class containing the main operations of the calculator:
// addition, subtraction, multiplication, and division.
// Principle used: Encapsulation – the logic is separated from the User Interface layer.

namespace Calc.Models
{
    // The Calculator class contains methods for the basic arithmetic operations:
    // addition, subtraction, multiplication, and division.
    public class Calculator
    {

        // This is the sum, + respectively Add.
        public double Add(double a, double b)
        {
            return a + b;
        }

        // This is the difference, - respectively Subtract.
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Here is the product – Multiply.
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // And the quotient of two numbers – Divide.
        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
