using NUnit.Framework;
using Services;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        private ICalculator _calc;
        public void Setup()
        {
            _calc = new Calculator();
        }

        [Test]
        public void AddNumbersWithNoInput()
        {
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
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOf200()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOfZero()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOfNegativeNumber()
        {
            Assert.Inconclusive("Test not fully implemented");
        }
    }
}