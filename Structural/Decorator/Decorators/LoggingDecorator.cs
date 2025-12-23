namespace DesignPatterns.Structural.Decorator.Decorators;

public sealed class LoggingDecorator : NotificationSenderDecorator
{
    public LoggingDecorator(INotificationSender inner) : base(inner) { }

    public override void Send(string recipient, string message)
    {
        Console.WriteLine($"[LOG] Sending to {recipient}");
        Inner.Send(recipient, message);
        Console.WriteLine($"[LOG] Sent to {recipient}");
    }
}