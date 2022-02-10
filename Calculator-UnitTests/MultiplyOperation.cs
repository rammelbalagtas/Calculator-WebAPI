using Calculator_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_UnitTests
{
    [TestClass]
    public class MultiplyOperation
    {
        //Test multiplication of two positive numbers
        [TestMethod]
        [DataRow(1, 2, 2)]
        [DataRow(10, 12, 120)]
        [DataRow(100, 200, 20000)]
        public void MultiplyOperation_InputTwoPositiveNumbers_ReturnProduct(int lValue, int rValue, int expected)
        {
            Assert.AreEqual(expected, Calculator.Multiply(lValue, rValue));
        }

        //Test multiplication of one positive and one negative number
        [TestMethod]
        [DataRow(1, -2)]
        [DataRow(-10, 12)]
        [DataRow(100, -200)]
        public void MultiplyOperation_InputOnePositiveOneNegative_ReturnProductWithNegativeSign(int lValue, int rValue)
        {
            Assert.IsTrue(Calculator.Multiply(lValue, rValue) < 0);
        }

        //Test multiplication of two negative numbers
        [TestMethod]
        [DataRow(-1, -2)]
        [DataRow(-10, -12)]
        [DataRow(-100, -200)]
        public void MultiplyOperation_InputTwoNegativeNumbers_ReturnProductWithPositiveSign(int lValue, int rValue)
        {
            Assert.IsTrue(Calculator.Multiply(lValue, rValue) > 0);
        }

        //Test multiplication of a number to zero
        [TestMethod]
        [DataRow(-1, 0)]
        [DataRow(0, 12)]
        public void MultiplyOperation_MultiplyZeroByAnyNumber_ReturnProducEqualToZero(int lValue, int rValue)
        {
            Assert.IsTrue(Calculator.Multiply(lValue, rValue) == 0);
        }
    }
}
