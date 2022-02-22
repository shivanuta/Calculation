using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operations
{
    /// <summary>
    /// This entity contains multiplication operation.
    /// </summary>
    public class Multiplication
    {
        /// <summary>
        /// This method calculate the multiplication operation.
        /// </summary>
        /// <param name="number1">integer number1</param>
        /// <param name="number2">integer number2</param>
        /// <returns>method returns the multiplication of two numbers</returns>
        public float Mul(float number1, float number2)
        {
            try
            {
                return number1 * number2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
