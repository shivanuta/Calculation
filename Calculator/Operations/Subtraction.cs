using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operations
{
    /// <summary>
    /// This entity contains Subtraction operation.
    /// </summary>
    public class Subtraction
    {
        /// <summary>
        /// This method calculate the subtraction operation.
        /// </summary>
        /// <param name="number1">integer number1</param>
        /// <param name="number2">integer number2</param>
        /// <returns>method returns the subtraction of two numbers</returns>
        public int Sub(int number1, int number2)
        {
            try
            {
                return number1 - number2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
