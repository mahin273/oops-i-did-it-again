using System;
using System.Collections.Generic;

class Notification
{
    public string Message { get; set; }

    public Notification(string message)
    {
        Message = message;
    }

    public virtual void Send()
    {
        Console.WriteLine($"Sending: {Message}");
    }
}

class EmailNotification : Notification
{
    public string ToEmail { get; set; }

    public EmailNotification(string message, string email) : base(message)
    {
        ToEmail = email;
    }

    public override void Send()
    {
        Console.WriteLine($"Email to {ToEmail}: {Message}");
    }
}

class SMSNotification : Notification
{
    public string PhoneNumber { get; set; }

    public SMSNotification(string message, string phone) : base(message)
    {
        PhoneNumber = phone;
    }

    public override void Send()
    {
        Console.WriteLine($"SMS to {PhoneNumber}: {Message}");
    }
}

class PushNotification : Notification
{
    public PushNotification(string message) : base(message) { }

    public override void Send()
    {
        Console.WriteLine($"Push notification: {Message}");
    }
}

public static class RuntimePolymorphism
{
    public static void Run()
    {
        List<Notification> notifications = new List<Notification>
        {
            new EmailNotification("Your Order Shipped", "mahin@dev.io"),
            new SMSNotification("OTP: 123456", "+8801700000000"),
            new PushNotification("New message received")
        };

        foreach (Notification n in notifications)
        {
            n.Send();   // This will now correctly execute runtime polymorphism!
        }
    }
}
