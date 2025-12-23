namespace DesignPatterns.Structural.Decorator;

public interface INotificationSender
{
    void Send(string recipient, string message);
}