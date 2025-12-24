namespace DesignPatterns.Creational.FactoryMethod.Creators;

public sealed class EmailNotificationCreator : NotificationCreator
{
    protected override INotification CreateNotification()
        => new EmailNotification();
}