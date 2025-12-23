using System.Text;

namespace DesignPatterns.Structural.Decorator.Decorators;


public sealed class EncryptionDecorator : NotificationSenderDecorator
{
    public EncryptionDecorator(INotificationSender inner) : base(inner) { }

    public override void Send(string recipient, string message)
    {
        var encrypted = Convert.ToBase64String(Encoding.UTF8.GetBytes(message));
        Inner.Send(recipient, encrypted);
    }
}