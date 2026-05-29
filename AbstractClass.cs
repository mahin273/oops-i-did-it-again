using System;

abstract class PaymentProcessor
{
    public string Currency { get; set; } = "USD";

    // Abstract method — no implementation, MUST be overridden
    public abstract bool ProcessPayment(decimal amount);

    // Non-abstract method — has implementation, can be inherited as-is
    public void LogTransaction(decimal amount)
    {
        Console.WriteLine($"[LOG] Processing {Currency} {amount:F2}");
    }
}

class StripeProcessor : PaymentProcessor
{
    private string _apiKey;

    public StripeProcessor(string apiKey)
    {
        _apiKey = apiKey;
    }

    public override bool ProcessPayment(decimal amount)
    {
        LogTransaction(amount);       // inherited method
        Console.WriteLine($"Stripe: charged {amount:C} using key {_apiKey[..4]}...");
        return true;
    }
}

class SSLCommerzProcessor : PaymentProcessor
{
    public SSLCommerzProcessor()
    {
        Currency = "BDT";
    }

    public override bool ProcessPayment(decimal amount)
    {
        LogTransaction(amount);
        Console.WriteLine($"SSLCommerz: processing BDT {amount}");
        return true;
    }
}

public static class AbstractClass
{
    public static void Run()
    {
        // Cannot do: new PaymentProcessor()  — it's abstract!
        PaymentProcessor stripe = new StripeProcessor("sk_live_abc123xyz");
        PaymentProcessor ssl = new SSLCommerzProcessor();

        stripe.ProcessPayment(99.99m);
        ssl.ProcessPayment(5000m);

    }
}


