namespace DesignPatterns.Structural.Bridge.Senders;

public sealed class EmailSender : INotificationSender
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"EMAIL to {recipient}: {message}");
    }
}