namespace DesignPatterns.Creational.FactoryMethod;

public sealed class EmailNotification : INotification
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"EMAIL -> {recipient}: {message}");
    }
}