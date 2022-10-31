using Calculator.Method;
using Xunit;

namespace Methods.Tests.NUnitTests
{
    public class CalculatorTestSum
    {
        [Fact]
        public void TestSum()
        {
            CalculateMethod calculateMethod = new();
            string result = calculateMethod.Calculate(1,1,"1");
            Assert.Equal("2", result);
        }
    }
}
