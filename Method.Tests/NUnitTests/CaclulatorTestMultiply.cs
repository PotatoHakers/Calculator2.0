using Xunit;
using Calculator.Method;

namespace Methods.Tests.NUnitTests
{
    public class CaclulatorTestMultiply
    {
        [Fact]
        public void TestMultiply()
        {
            CalculateMethod calculateMethod = new();
            string result = calculateMethod.Calculate(3, 3, "3");
            Assert.Equal("9", result);
        }
    }
}
