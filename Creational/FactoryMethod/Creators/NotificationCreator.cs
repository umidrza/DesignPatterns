namespace DesignPatterns.Creational.FactoryMethod.Creators;

// Creator
public abstract class NotificationCreator
{
    // Factory Method
    protected abstract INotification CreateNotification();

    // Business logic using the product
    public void Notify(string recipient, string message)
    {
        var notification = CreateNotification();
        notification.Send(recipient, message);
    }
}