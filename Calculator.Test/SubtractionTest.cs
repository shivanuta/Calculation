using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Test
{
    public class SubtractionTest
    {
        [Fact]
        public void SubtractionTest1()
        {
            Subtraction subtraction = new Subtraction();
            int result;
            result = subtraction.Sub(1, 1);

            Assert.Equal(result, 0);
        }

        [Fact]
        public void SubtractionTest2()
        {
            Subtraction subtraction = new Subtraction();
            int result;
            result = subtraction.Sub(2, 1);

            Assert.Equal(result, 1);
        }

        [Fact]
        public void SubtractionTest3()
        {
            Subtraction subtraction = new Subtraction();
            int result;
            result = subtraction.Sub(5, 1);

            Assert.False(result == 7);
        }

        [Fact]
        public void SubtractionTest4()
        {
            Subtraction subtraction = new Subtraction();
            int result;
            result = subtraction.Sub(1, 10);

            Assert.True(result == -9);
        }

        [Fact]
        public void SubtractionTest5()
        {
            Subtraction subtraction = new Subtraction();
            int result;
            result = subtraction.Sub(10, 10);

            Assert.True(result == 0);
        }

        [Fact]
        public void SubtractionTest7()
        {
            Subtraction subtraction = new Subtraction();
            int result;
            result = subtraction.Sub(100, 10);

            Assert.True(result == 90);
        }

        [Fact]
        public void SubtractionTest6()
        {
            Subtraction subtraction = new Subtraction();
            int result;
            result = subtraction.Sub(12, 10);

            Assert.True(result == 2);
        }

        [Fact]
        public void SubtractionTest8()
        {
            Subtraction subtraction = new Subtraction();
            int result;
            result = subtraction.Sub(50, 1);

            Assert.False(result == 40);
        }

        [Fact]
        public void SubtractionTest9()
        {
            Subtraction subtraction = new Subtraction();
            int result;
            result = subtraction.Sub(5, 10);

            Assert.False(result == -50);
        }

        [Fact]
        public void SubtractionTest10()
        {
            Subtraction subtraction = new Subtraction();
            int result;
            result = subtraction.Sub(20, 1);

            Assert.False(result == 7);
        }
    }
}
