using Calculator.Method;
using Xunit;

namespace Methods.Tests.NUnitTests
{
    public class CalculatorTestDivide
    {
        [Fact]
        public void TestDivide()
        {
            CalculateMethod calculateMethod = new();
            string result = calculateMethod.Calculate(100, 4, "10");
            Assert.Equal("10", result);
        }
    }
}
