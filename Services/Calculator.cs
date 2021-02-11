using System;
using System.Linq;

namespace Services
{
    public class Calculator : ICalculator
    {
        public double Add(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Subtract(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Multiply(params double[] numbers)
        {
            double myNum = numbers[0];
            for (int i = 1; i != numbers.Length; i++)
            {
                myNum *= numbers[i];
            }
            return myNum;
        }

        public double Divide(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Factorial(double number)
        {
            throw new NotImplementedException();
        }
    }
}