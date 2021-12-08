using Xunit;
using StringCalculator;
using System;

namespace TestProject1
{
    public class StringCalculatorTest
    {
        [Fact]
        public void GivenAnEmptyStringThenReturnZero()
        {
            int result = Calculator.Add("");
            Assert.Equal(0, result);
        }
        [Fact]
        public void GivenAStringWithOneThenReturns()
        {
            int result = Calculator.Add("1");
            Assert.Equal(1, result);
        }
        [Fact]
        public void GivenAStringWithTwoNumbersThenReturnsTheSum()
        {
            int result = Calculator.Add("1,2");
            Assert.Equal(3, result);
        }
        [Theory]
        [InlineData(2, "1,1")]
        [InlineData(5, "1,4")]
        [InlineData(20, "11,9")]
        [InlineData(11, "1,1,9")]
        public void GivenAStringWithAnUnknownNumberThenReturnsTheSum(int expected, string input)
        {
            int result = Calculator.Add(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenAStringWithALineBreakThenReturnsTheSum()
        {
            int result = Calculator.Add("1\n2, 3");
            Assert.Equal(6, result);
        }

        [Fact]
        public void GivenAStringWithDelimetersThenReturnsASum()
        {
            int result = Calculator.Add("//;\n1;2");
            Assert.Equal(3, result);
        }
        [Theory]
        [InlineData("-1")]
        [InlineData("-3")]
        public void CallingANegativeNumberThrowsException(string input)
        {
            Assert.Throws<ArgumentException>(() => Calculator.Add(input));
        }
        [Theory]
        [InlineData(2, "2, 1001")]
        [InlineData(3, "5000, 3")]
        [InlineData(4, "5000, 4, 1002")]
        public void IgnoreNumbersGreaterThan1000(int expected, string input)
        {
            int result = Calculator.Add(input);
            Assert.Equal(expected, result);
        }
    }
  
}