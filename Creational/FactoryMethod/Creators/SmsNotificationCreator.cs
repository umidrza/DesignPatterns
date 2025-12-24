namespace DesignPatterns.Creational.FactoryMethod.Creators;

public sealed class SmsNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
        => new SmsNotification();
}
