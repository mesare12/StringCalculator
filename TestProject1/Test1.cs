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
    }
}