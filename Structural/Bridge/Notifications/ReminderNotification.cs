namespace DesignPatterns.Structural.Bridge.Notifications;

public sealed class ReminderNotification : Notification
{
    public ReminderNotification(INotificationSender sender) : base(sender) { }

    public override void Notify(string recipient, string content)
    {
        Sender.Send(recipient, $"[REMINDER] {content}");
    }
}