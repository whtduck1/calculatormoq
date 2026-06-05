using Xunit;
using Moq;
using CalculatorApp;

namespace CalculatorApp.Tests;

public class OrderServiceTests
{
    [Fact]
    public void PlaceOrder_ShouldCallProcessPayment_OnceAndWithCorrectParameters()
    {
        var paymentProcessorMock = new Mock<IPaymentProcessor>();

        paymentProcessorMock
            .Setup(p => p.ProcessPayment(It.IsAny<decimal>(), It.IsAny<string>()))
            .Returns(true);

        var orderService = new OrderService(paymentProcessorMock.Object);

        decimal testAmount = 150.50m;
        string testCurrency = "PLN";

        orderService.PlaceOrder(testAmount, testCurrency);

        paymentProcessorMock.Verify(
            p => p.ProcessPayment(testAmount, testCurrency),
            Times.Once
        );
    }
}