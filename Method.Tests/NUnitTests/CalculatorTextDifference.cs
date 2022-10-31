using Calculator.Method;
using Xunit;

namespace Methods.Tests.NUnitTests
{
    public class CalculatorTextDifference
    {
        [Fact]
        public void TestDifference()
        {
            CalculateMethod calculateMethod = new();
            string result = calculateMethod.Calculate(3, 2, "1");
            Assert.Equal("2", result);
        }
    }
}
