using System.Text.RegularExpressions;

namespace DesignPatterns.Structural.Adapter.Email_Senders;

public class SmtpEmailSender : IEmailSender
{
    public EmailResult Send(EmailMessage message)
    {
        if (!LooksLikeEmail(message.To))
            return EmailResult.Failed("SMTP: recipient email format is invalid.");

        // Simulate sending + message id creation
        var messageId = $"SMTP-{Guid.NewGuid():N}"[..12];

        var info = $"SMTP sent to {message.To}.";

        return EmailResult.Sent(messageId, info);
    }

    private static bool LooksLikeEmail(string input)
    {
        // Simple format check for demo purposes (not a perfect validator)
        return Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }
}
