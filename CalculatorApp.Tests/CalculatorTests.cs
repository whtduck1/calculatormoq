using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator;
    public CalculatorTests()
    {
        _calculator = new Calculator();
    }
    [Fact]
    public void ShouldAddTwoNumbers()
    {
        var calculator = new Calculator();
        double result = calculator.Add(1, 2);
        Assert.Equal(3, result);
    }
    [Fact]
    public void ShouldDivideTwoNumbers()
    {
        var calculator = new Calculator();
        double result = calculator.Divide(4, 2);
        Assert.Equal(2, result);
    }
    [Fact]
    public void ShouldSubtractTwoNumbers()
    {
        var calculator = new Calculator();
        double result = calculator.Subtract(3, 2);
        Assert.Equal(1, result);
    }
    [Fact]
    public void ShouldMultiplyTwoNumbers()
    {
        var calculator = new Calculator();
        double result = calculator.Multiply(3, 2);
        Assert.Equal(6, result);
    }
    [Fact]
    public void ShouldThrowExceptionWhenDividingByZero()
    {
        var exception = Assert.Throws<ArgumentException>(() => _calculator.Divide(4, 0));
        Assert.Equal("Division by zero is not allowed.", exception.Message);
    }
}
