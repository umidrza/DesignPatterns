namespace DesignPatterns.Structural.Adapter;

public interface IEmailSender
{
    EmailResult Send(EmailMessage message);
}