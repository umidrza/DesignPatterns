namespace DesignPatterns.Structural.Bridge.Senders;

public sealed class SmsSender : INotificationSender
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"SMS to {recipient}: {message}");
    }
}