namespace DesignPatterns.Structural.Bridge.Notifications;

public sealed class AlertNotification : Notification
{
    public AlertNotification(INotificationSender sender) : base(sender) { }

    public override void Notify(string recipient, string content)
    {
        Sender.Send(recipient, $"[ALERT] {content}");
    }
}