using Calculator_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_UnitTests
{
    [TestClass]
    public class SubtractOperation
    {
        //Test subtraction of two positive numbers
        [TestMethod]
        [DataRow(1, 2, -1)]
        [DataRow(14, 12, 2)]
        [DataRow(111, 222, -111)]
        public void SubtractOperation_InputTwoPositiveNumbers_ReturnDifference(int lValue, int rValue, int expected)
        {
            Assert.AreEqual(expected, Calculator.Subtract(lValue, rValue));
        }

        //Test subtraction of one positive and one negative number
        [TestMethod]
        [DataRow(5, -4, 9)]
        [DataRow(-15, 11, -26)]
        [DataRow(200, -100, 300)]
        public void SubtractOperation_InputOnePositiveOneNegative_ReturnDifference(int lValue, int rValue, int expected)
        {
            Assert.AreEqual(expected, Calculator.Subtract(lValue, rValue));
        }

        //Test subtraction of two negative numbers
        [TestMethod]
        [DataRow(-1, -2, 1)]
        [DataRow(-30, -20, -10)]
        [DataRow(-100, -100, 0)]
        public void SubtractOperation_InputTwoNegativeNumbers_ReturnDifference(int lValue, int rValue, int expected)
        {
            Assert.AreEqual(expected, Calculator.Subtract(lValue, rValue));
        }
    }
}
