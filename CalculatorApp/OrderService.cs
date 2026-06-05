using System;

namespace CalculatorApp;

public class OrderService
{
    private readonly IPaymentProcessor _paymentProcessor;

    public OrderService(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor ?? throw new ArgumentNullException(nameof(paymentProcessor));
    }

    public bool PlaceOrder(decimal amount, string currency)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(">0");
        }

        return _paymentProcessor.ProcessPayment(amount, currency);
    }
}