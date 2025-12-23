namespace DesignPatterns.Structural.Decorator;

public sealed class EmailSender : INotificationSender
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"EMAIL to {recipient}: {message}");
    }
}