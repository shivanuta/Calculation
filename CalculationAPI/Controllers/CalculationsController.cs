using Calculator.Operations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationsController : ControllerBase
    {/// <summary>
     /// This method calculate the add operation.
     /// </summary>
     /// <param name="number1">integer number1</param>
     /// <param name="number2">integer number2</param>
     /// <returns>method returns the addition of two numbers</returns>
        [HttpPost]
        [Route("Addition")]
        public IActionResult Addition(int number1, int number2)
        {
            try
            {
                Addition addition = new Addition();
                int add = addition.Add(number1, number2);
                return Ok(add);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// This method calculate the subtraction operation.
        /// </summary>
        /// <param name="number1">integer number1</param>
        /// <param name="number2">integer number2</param>
        /// <returns>method returns the subtraction of two numbers</returns>
        [HttpPost]
        [Route("Subtraction")]
        public IActionResult Sub(int number1, int number2)
        {
            try
            {
                Subtraction subtraction = new Subtraction();
                return Ok(subtraction.Sub(number1, number2));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// This method calculate the division operation.
        /// </summary>
        /// <param name="number1">decimal number1</param>
        /// <param name="number2">decimal number2</param>
        /// <returns>method returns the division of two numbers</returns>
        [HttpPost]
        [Route("Division")]
        public IActionResult Div(decimal number1, decimal number2)
        {
            try
            {
                Division divition = new Division();
                return Ok(divition.Div(number1, number2));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// This method calculate the multiplication operation.
        /// </summary>
        /// <param name="number1">integer number1</param>
        /// <param name="number2">integer number2</param>
        /// <returns>method returns the multiplication of two numbers</returns>
        [HttpPost]
        [Route("Multiplication")]
        public IActionResult Mul(int number1, int number2)
        {
            try
            {
                Multiplication multiplication = new Multiplication();
                return Ok(multiplication.Mul(number1, number2));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
