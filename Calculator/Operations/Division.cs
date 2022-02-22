using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operations
{
    /// <summary>
    /// This entity contains division operation.
    /// </summary>
    public class Division
    {
        /// <summary>
        /// This method calculate the division operation.
        /// </summary>
        /// <param name="number1">decimal number1</param>
        /// <param name="number2">decimal number2</param>
        /// <returns>method returns the division of two numbers</returns>
        public decimal Div(decimal number1, decimal number2)
        {
            try
            {
                return decimal.Divide(number1, number2);
            }
            catch (DivideByZeroException e)
            {
                throw;
            }
        }
    }
}
