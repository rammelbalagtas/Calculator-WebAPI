using Calculator_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_UnitTests
{
    [TestClass]
    public class DivideOperation
    {
        //Test normal division of two numbers
        [TestMethod]
        [DataRow(1, 2, 0.5)]
        [DataRow(120, 10, 12)]
        [DataRow(1500, 100, 15)]
        public void DivideOperation_InputTwoPositiveNumbers_ReturnQuotient(int lValue, int rValue, double expected)
        {
            Assert.AreEqual(expected, Calculator.Divide(lValue, rValue));
        }

        //Test division of one positive and one negative number, result should be less than 0
        [TestMethod]
        [DataRow(1, -2, -0.5)]
        [DataRow(-120, 10, -12)]
        [DataRow(1500, -100, -15)]

        public void DivideOperation_InputOnePositiveOneNegative_ReturnQuotientWithNegativeSign(int lValue, int rValue, double expected)
        {
            Assert.IsTrue(Calculator.Divide(lValue, rValue) < 0);
            Assert.AreEqual(expected, Calculator.Divide(lValue, rValue));
        }

        //Test division of two negative numbers, result should be greater than 0
        [TestMethod]
        [DataRow(-1, -2, 0.5)]
        [DataRow(-120, -10, 12)]
        [DataRow(-1500, -100, 15)]
        public void DivideOperation_InputTwoNegativeNumbers_ReturnQuotientWithPositiveSign(int lValue, int rValue, double expected)
        {
            Assert.IsTrue(Calculator.Divide(lValue, rValue) > 0);
            Assert.AreEqual(expected, Calculator.Divide(lValue, rValue));
        }

        //Test division where zero is the denominator, result should return exception
        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(12, 0)]
        public void DivideOperation_ZeroDenominator_ReturnDivideByZeroException(int lValue, int rValue)
        {
            Assert.ThrowsException<DivideByZeroException>(() => Calculator.Divide(lValue, rValue));
        }

        //Test division with zero numerator, result should be equal to zero
        [TestMethod]
        [DataRow(0, 1)]
        [DataRow(0, -12)]
        public void DivideOperation_InputZeroAsNumerator_ReturnZeroAsQuotient(int lValue, int rValue)
        {
            Assert.AreEqual(0, Calculator.Divide(lValue, rValue));
        }
    }
}
