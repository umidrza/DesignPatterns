namespace DesignPatterns.Creational.FactoryMethod;

public interface INotification
{
    void Send(string recipient, string message);
}