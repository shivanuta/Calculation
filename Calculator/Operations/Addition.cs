using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    /// <summary>
    /// This entity contains addition operation.
    /// </summary>
    public class Addition
    {/// <summary>
     /// This method calculate the add operation.
     /// </summary>
     /// <param name="number1"></param>
     /// <param name="number2"></param>
     /// <returns></returns>
        public int Add(int number1, int number2)
        {
            try
            {
                return number1 + number2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
