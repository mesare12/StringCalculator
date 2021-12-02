using Xunit;
using StringCalculator;
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
        [Fact]
        public void GivenAStringWithALineBreakThenReturnsTheSum()
        {
            int result = Calculator.Add("1\n2, 3");
            Assert.Equal(6, result);
        }
    }
}