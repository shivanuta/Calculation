using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Test
{
    public class DivisionTest
    {
        [Fact]
        public void DivisionTest1()
        {
            Division division = new Division();

            Assert.Throws<DivideByZeroException>(() => {

                // Act (the actual operation)
                var result = division.Div(1, 0);

                // Then, Assert
                Assert.IsType<decimal>(result);
            });
        }

        [Fact]
        public void DivisionTest7()
        {
            Division division = new Division();
            decimal result;
            result = division.Div(120, 100);

            Assert.True(result == Convert.ToDecimal(1.2));
        }

        [Fact]
        public void DivisionTest2()
        {
            Division division = new Division();
            decimal result;
            result = division.Div(2, 1);

            Assert.Equal(result, 2);
        }

        [Fact]
        public void DivisionTest3()
        {
            Division division = new Division();
            decimal result;
            result = division.Div(5, 1);

            Assert.False(result == 50);
        }

        [Fact]
        public void DivisionTest4()
        {
            Division division = new Division();
            decimal result;
            result = division.Div(100, 10);

            Assert.True(result == 10);
        }

        [Fact]
        public void DivisionTest5()
        {
            Division division = new Division();
            decimal result;
            result = division.Div(10, 10);

            Assert.True(result == 1);
        }

        [Fact]
        public void DivisionTest6()
        {
            Division division = new Division();
            decimal result;
            result = division.Div(12, 10);

            Assert.True(result == Convert.ToDecimal(1.2));
        }

        [Fact]
        public void DivisionTest8()
        {
            Division division = new Division();
            decimal result;
            result = division.Div(50, 1);

            Assert.False(result == 7);
        }

        [Fact]
        public void DivisionTest9()
        {
            Division division = new Division();
            decimal result;
            result = division.Div(50, 10);

            Assert.False(result == 7);
        }

        [Fact]
        public void DivisionTest10()
        {
            Division division = new Division();
            decimal result;
            result = division.Div(20, 1);

            Assert.False(result == 7);
        }
    }
}
