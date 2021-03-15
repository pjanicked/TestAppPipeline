using System.Diagnostics.CodeAnalysis;
using Xunit;
using Calc = Calculator.Lib.Calculator;

namespace Calculator.Tests
{
    [ExcludeFromCodeCoverage]
    public class CalculatorTests
    {
        [Fact]
        public void PassingTest()
        {
            var calculator = new Calc();
            Assert.Equal(4, calculator.Add(2, 2));
            //Assert.Equal(0, calculator.Add(0, 0));
        }
    }
}
