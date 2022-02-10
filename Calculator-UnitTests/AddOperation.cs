using Calculator_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_UnitTests
{
    [TestClass]
    public class AddOperation
    {
        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(12, 14, 26)]
        [DataRow(111, 222, 333)]
        public void AddOperation_InputTwoPositiveNumbers_ReturnSum(int lValue, int rValue, int expected)
        {
            Assert.AreEqual(expected, Calculator.Add(lValue, rValue));
        }

        [TestMethod]
        [DataRow(5, -4, 1)]
        [DataRow(-15, 11, -4)]
        [DataRow(-200, 100, -100)]
        public void AddOperation_InputOnePositiveOneNegative_ReturnSum(int lValue, int rValue, int expected)
        {
            Assert.AreEqual(expected, Calculator.Add(lValue, rValue));
        }

        [TestMethod]
        [DataRow(-1, -2, -3)]
        [DataRow(-10, -20, -30)]
        [DataRow(-100, -200, -300)]
        public void AddOperation_InputTwoNegativeNumbers_ReturnSum(int lValue, int rValue, int expected)
        {
            Assert.AreEqual(expected, Calculator.Add(lValue, rValue));
        }
    }
}
