namespace DesignPatterns.Structural.Bridge;


public abstract class Notification
{
    protected readonly INotificationSender Sender;

    protected Notification(INotificationSender sender)
        => Sender = sender;

    public abstract void Notify(string recipient, string content);
}