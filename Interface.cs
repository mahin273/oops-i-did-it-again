using System;

interface IPaymentGateway
{
    bool Charge(string customerId, decimal amount);
    bool Refund(string transactionId);
}

interface INotificationService
{
    void SendConfirmation(string email,string message);
}

class StripeGateway: IPaymentGateway
{
    public bool Charge(string customerId,decimal amount)
    {
        Console.WriteLine($"Stripe: Charging {amount:C} to customer {customerId}");
        return true;
    }

    public bool Refund(string transactionId)
    {
        Console.WriteLine($"Stripe: Refunding transaction {transactionId}");
        return true;
    }
}

class EmailService : INotificationService
{
    public void SendConfirmation(string email, string message)
    {
        Console.WriteLine($"Email to {email}: {message}");
    }
}

class CheckoutService
{
    private readonly IPaymentGateway _gateway;
    private readonly INotificationService _notifier;

    public CheckoutService(IPaymentGateway gateway, INotificationService notifier)
    {
        _gateway = gateway;
        _notifier = notifier;
    }

    public void ProcessOrder(string customerId, string email, decimal amount)
    {
        bool success = _gateway.Charge(customerId, amount);
        if (success)
        {
            _notifier.SendConfirmation(email, $"Your Payment of {amount:C} was successful. ");
        }
    }
}

public static class IPaymentGatewayDemo
{
    public static void Run()
    {
        CheckoutService checkout = new CheckoutService(new StripeGateway(), new EmailService());
        checkout.ProcessOrder("cust_123", "mahin@dev.io", 199.99m);
    }
}