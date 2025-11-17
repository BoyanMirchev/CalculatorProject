
// Автор: Боян Ангелов Мирчев
// Факултетен номер: F113037
// Файл: Calculator.cs
// Описание: Клас, съдържащ основните операции на калкулатора,
// събиране, изваждане, умножение и деление.
// Използван принцип: Инкапсулация – логиката е отделена от слоя на
// User Interface-a.

namespace Calc.Models
{
    // Клас Calculator съдържа методи за основните аритметични операции
    // събиране, изваждане, умножение и деление.
    public class Calculator
    {

        // Това е сумата, +  съответно Add. 
        
        public double Add(double a, double b)
        {
            return a + b;
        }

        //Това е разликата, -  съответно Subtract.
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        //  Тук е произведението - Multiply
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        // И частното на две числа - Divide
        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}