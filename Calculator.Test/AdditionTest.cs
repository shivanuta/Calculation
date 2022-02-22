using System;
using Xunit;
using Calculator.Operations;

namespace Calculator.Test
{
    public class AdditionTest
    {
        [Fact]
        public void AdditionTest1()
        {
            Addition addition = new Addition();
            int result;
            result = addition.Add(1, 1);

            Assert.Equal(result, 2);
        }

        [Fact]
        public void AdditionTest2()
        {
            Addition addition = new Addition();
            int result;
            result = addition.Add(2, 1);

            Assert.Equal(result, 3);
        }

        [Fact]
        public void AdditionTest3()
        {
            Addition addition = new Addition();
            int result;
            result = addition.Add(5, 1);

            Assert.False(result == 7);
        }

        [Fact]
        public void AdditionTest4()
        {
            Addition addition = new Addition();
            int result;
            result = addition.Add(1, 10);

            Assert.True(result == 11);
        }

        [Fact]
        public void AdditionTest5()
        {
            Addition addition = new Addition();
            int result;
            result = addition.Add(10, 10);

            Assert.True(result == 20);
        }

        [Fact]
        public void AdditionTest6()
        {
            Addition addition = new Addition();
            int result;
            result = addition.Add(12, 10);

            Assert.True(result == 22);
        }

        [Fact]
        public void AdditionTest7()
        {
            Addition addition = new Addition();
            int result;
            result = addition.Add(12, 100);

            Assert.True(result == 112);
        }

        [Fact]
        public void AdditionTest8()
        {
            Addition addition = new Addition();
            int result;
            result = addition.Add(50, 1);

            Assert.False(result == 7);
        }

        [Fact]
        public void AdditionTest9()
        {
            Addition addition = new Addition();
            int result;
            result = addition.Add(5, 10);

            Assert.False(result == 7);
        }

        [Fact]
        public void AdditionTest10()
        {
            Addition addition = new Addition();
            int result;
            result = addition.Add(20, 1);

            Assert.False(result == 7);
        }
    }
}
