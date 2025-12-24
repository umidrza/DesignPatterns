namespace DesignPatterns.Creational.FactoryMethod;

public sealed class SmsNotification : INotification
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"SMS -> {recipient}: {message}");
    }
}