using System;

namespace Calculator_ClassLibrary
{
    public static class Calculator
    {
        // Method for adding 2 integers
        public static int Add(int lValue, int rValue)
        {
            return lValue + rValue;
        }

        // Method for subtracting 2 integers
        public static int Subtract(int lValue, int rValue)
        {
            return lValue - rValue;
        }

        // Method for multiplying 2 integers
        public static int Multiply(int lValue, int rValue)
        {
            return lValue * rValue;
        }

        // Method for dividing 2 integers
        public static double Divide(int lValue, int rValue)
        {
            if (rValue != 0)
            {
                return lValue / rValue;
            } 
            else
            {
                //throw exception for dividing by zero
                throw new DivideByZeroException();
            }
        }

    }
}
