namespace DesignPatterns.Structural.Adapter;

public sealed class EmailMessage
{
    public string To { get; }
    public string Subject { get; }
    public string Body { get; }

    public EmailMessage(string to, string subject, string body)
    {
        To = to.Trim();
        Subject = subject.Trim();
        Body = body;
    }
}