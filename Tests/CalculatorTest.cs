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
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoNumbersWithZero()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideThreeNumbersWithZero()
        {
            Assert.Inconclusive("Test not fully implemented");
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