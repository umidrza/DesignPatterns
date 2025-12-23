namespace DesignPatterns.Structural.Decorator.Decorators;

public abstract class NotificationSenderDecorator : INotificationSender
{
    protected readonly INotificationSender Inner;

    protected NotificationSenderDecorator(INotificationSender inner)
        => Inner = inner;

    public abstract void Send(string recipient, string message);
}