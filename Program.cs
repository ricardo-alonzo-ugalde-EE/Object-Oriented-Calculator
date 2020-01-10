using System;

namespace _76_Object_Oriented_Calculator
{   class Calculator // class named Calculator
    {
        private double result; // data member that we will use to store the result of calculations

        public Calculator()  // Constructor named Calculator sets result to 0
        {
            result = 0;
        }
        public double Add(double operand1, double operand2) // simple addition method
        {
            result = operand1 + operand2;
            return result;
        }
        public double Sub(double operand1, double operand2) // simple subtraction method
        {
            result = operand1 - operand2;
            return result;
        }
        public double Divvy(double operand1, double operand2) // simple division method
        {
            result = operand1 / operand2;
            return result;
        }
        public double Milti(double operand1, double operand2) // simple multiplication method
        {
            result = operand1 * operand2;
            return result;
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(); // call the Calculator constructor and the object calc
            Console.WriteLine(calc.Add(1, 1));
            Console.WriteLine(calc.Sub(1, 1));
            Console.WriteLine(calc.Milti(1, 1));
            Console.WriteLine(calc.Divvy(1, 1));
        }
    }
}
