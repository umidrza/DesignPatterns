namespace DesignPatterns.Structural.Bridge;

public interface INotificationSender
{
    void Send(string recipient, string message);
}