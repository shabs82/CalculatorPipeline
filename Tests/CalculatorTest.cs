using NUnit.Framework;
using Services;
using System;



namespace Tests
{
    public class Tests
    {
        private ICalculator _calc;
        [SetUp]
        public void Setup()
        {
            _calc = new Calculator();
        }

        [Test]
        public void AddNumbersWithNoInput()
        {
            _calc.Add();
           Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void AddThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideNumbersWithNoInput()
        {
            try
            {
                double[] numbers = new double[2];
                _calc.Divide(numbers);
            }
            catch (ArgumentNullException e)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            double[] numbers = { 12.0, 2.0 };
            double result = _calc.Divide(numbers);
            Assert.AreEqual(6.0, result);

        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            try
            {
                double[] numbers = { -12.0, -2.0 };
                double myResult = _calc.Divide(numbers);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Pass();
            }

        }

        [Test]
        public void DivideTwoNumbersWithZero()
        {
            try
            {
                double[] numbers = { 0, 2.0 };
                double myResult = _calc.Divide(numbers);
            }
            catch (DivideByZeroException e)
            {
                Assert.Pass();
            }
            
        }

        [Test]
        public void DivideThreeNumbersWithZero()
        {
            try
            {
                double[] numbers = { 0, 2.0, 5.0 };
                double myResult = _calc.Divide(numbers);
            }
            catch (DivideByZeroException e)
            {
                Assert.Pass();
            }
        }


        [Test]
        public void FactorialOfFive()
        {
            double myResult = _calc.Factorial(5);
            Assert.Equals(120, myResult);
        }

        [Test]
        public void FactorialOf200()
        {
            try
            {
                double myResult = _calc.Factorial(200);
            }
            catch (Exception e)
            {
                Assert.Throws<Exception>(() => e.GetType());
            }

        }

        [Test]
        public void FactorialOfZero()
        {
            double myResult = _calc.Factorial(0);
            Assert.Equals(1, myResult);
        }

        [Test]
        public void FactorialOfNegativeNumber()
        {
            try
            {
                double myResult = _calc.Factorial(-1);
            }
            catch (Exception e)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => e.GetType());
            }
        }
    }
}