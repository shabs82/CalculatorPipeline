using System;
using System.Linq;

namespace Services
{
    public class Calculator : ICalculator
    {
        public double Add(params double[] numbers)
        {
             if (numbers.Length < 1) throw new InvalidDataException("Values required for Add method");


            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }

            return sum;
        }

        public double Subtract(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Multiply(params double[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentNullException();
            }
            else
            {
                double myNum = numbers[0];
                for (int i = 1; i != numbers.Length; i++)
                {
                    myNum *= numbers[i];
                }
                return myNum;
            }
        }

        public double Divide(params double[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentNullException();
            }
            else
            {
                double myNum = numbers[0];
                
                for (int i = 1; i < numbers.Length; i++)
                {
                    if(numbers[i] == 0){
                    throw new Exception("Cant be divided by 0");
                    }
                
                    myNum /= numbers[i];
                }
                return myNum;
            }
        }

        public double Factorial(double number)
        {
            if (number == 0) return 1;

            for (double ii = number - 1; ii >= 1; ii--)
            {
                number *= ii;
            }
            return number;

        }

    }
}
