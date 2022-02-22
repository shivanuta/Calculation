
using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Test
{
    public class MultiplicationTest
    {
        [Fact]
        public void MultiplicationTest1()
        {
            Multiplication multiplication = new Multiplication();
            float result;
            result = multiplication.Mul(1, 1);

            Assert.Equal(result, 1);
        }

        [Fact]
        public void MultiplicationTest2()
        {
            Multiplication multiplication = new Multiplication();
            float result;
            result = multiplication.Mul(2, 1);

            Assert.Equal(result, 2);
        }

        [Fact]
        public void MultiplicationTest3()
        {
            Multiplication multiplication = new Multiplication();
            float result;
            result = multiplication.Mul(5, 1);

            Assert.False(result == 7);
        }

        [Fact]
        public void MultiplicationTest4()
        {
            Multiplication multiplication = new Multiplication();
            float result;
            result = multiplication.Mul(1, 10);

            Assert.True(result == 10);
        }

        [Fact]
        public void MultiplicationTest5()
        {
            Multiplication multiplication = new Multiplication();
            float result;
            result = multiplication.Mul(10, 10);

            Assert.True(result == 100);
        }

        [Fact]
        public void MultiplicationTest6()
        {
            Multiplication multiplication = new Multiplication();
            float result;
            result = multiplication.Mul(12, 10);

            Assert.True(result == 120);
        }

        [Fact]
        public void MultiplicationTest7()
        {
            Multiplication multiplication = new Multiplication();
            float result;
            result = multiplication.Mul(12, 100);

            Assert.True(result == 1200);
        }

        [Fact]
        public void MultiplicationTest8()
        {
            Multiplication multiplication = new Multiplication();
            float result;
            result = multiplication.Mul(50, 1);

            Assert.False(result == 7);
        }

        [Fact]
        public void MultiplicationTest9()
        {
            Multiplication multiplication = new Multiplication();
            float result;
            result = multiplication.Mul(5, 10);

            Assert.False(result == 7);
        }

        [Fact]
        public void MultiplicationTest10()
        {
            Multiplication multiplication = new Multiplication();
            float result;
            result = multiplication.Mul(20, 1);

            Assert.False(result == 7);
        }
    }
}