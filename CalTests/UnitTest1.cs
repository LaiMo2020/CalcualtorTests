using System;
using Xunit;
using Calcualtor;

namespace CalConsoleTests
{

    public class CalTests
    {
        [Fact]
        public void AddTests()
        {
            var add = new CalConsole();
            double result = 3;
            ;
            var Addtests = CalConsole.Add(1, 2);

            Assert.Equal(result, Addtests);

        }

        [Fact]
        public void SubTests()
        {
            var sub = new CalConsole();
            double result = 0;
            var Subtests = CalConsole.Sub(2, 2);

            Assert.Equal(result, Subtests);

        }

        [Fact]
        public void MultTests()
        {
            var mult = new CalConsole();
            double result = 2;
            var Multtests = CalConsole.Mult(1, 2);
            Assert.Equal(result, Multtests);

        }

        [Fact]
        public void DivTests()
        {
            var div = new CalConsole();
            double result = 1;
            var Divtests = CalConsole.Div(2, 2);
            Assert.Equal(result, Divtests);

        }

        [Fact]
        public void DivideExceptionTests()
        {
            var divByZero = new CalConsole();
            double result = double.PositiveInfinity;
            var DivideExceptionTests = CalConsole.Div(2, 0);
            Assert.Equal(result, DivideExceptionTests);

        }

        [Fact]
        public void DivideExceptionNegativeTests()
        {
            var divByZero = new CalConsole();
            double result = double.NegativeInfinity;
            var DivideExceptionTests = CalConsole.Div(-2, 0);
            Assert.Equal(result, DivideExceptionTests);

        }

        [Theory]
        [InlineData(100, 100.50, 200.50)]
        [InlineData(-70, 200, 130)]
        [InlineData(300, 10, 310)]
        public void AddTests2(double firstN, double secondN, double expected)
        {
            double result = CalConsole.Add(firstN, secondN);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(200, 100.50, 99.50)]
        [InlineData(200, 200, 0)]
        [InlineData(300, 10, 290)]
        public void SubTests2(double firstN, double secondN, double expected)
        {
            double result = CalConsole.Sub(firstN, secondN);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(7, 100, 700)]
        [InlineData(1000, 9.5, 9500)]
        [InlineData(300, 10, 3000)]
        public void MultTests2(double firstN, double secondN, double expected)
        {
            double result = CalConsole.Mult(firstN, secondN);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(10, 100, 0.1)]
        [InlineData(1000, 50, 20)]
        [InlineData(300, 10, 30)]
        public void DivTests2(double firstN, double secondN, double expected)
        {
            double result = CalConsole.Div(firstN, secondN);

            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(-3, 0, double.NegativeInfinity)]
        [InlineData(1000, 0, double.PositiveInfinity)]
        public void DivTests3(double firstN, double secondN, double expected)
        {
            double result = CalConsole.Div(firstN, secondN);

            Assert.Equal(expected, result);

        }
    }
}

