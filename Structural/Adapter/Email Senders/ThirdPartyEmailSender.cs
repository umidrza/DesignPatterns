using DesignPatterns.Structural.Adapter.ThirdParty;

namespace DesignPatterns.Structural.Adapter.Email_Senders;

public sealed class ThirdPartyEmailSender : IEmailSender
{
    private readonly ThirdPartyMailer _mailer;

    public ThirdPartyEmailSender(ThirdPartyMailer mailer)
        => _mailer = mailer;

    public EmailResult Send(EmailMessage message)
    {
        // Translate domain message -> third-party request
        var request = new ThirdPartyMailRequest
        {
            Recipient = message.To,
            Title = message.Subject,
            HtmlBody = message.Body
        };

        var response = _mailer.SendMail(request);

        // Translate third-party response -> domain result
        return response.Ok
            ? EmailResult.Sent(response.MessageId, response.StatusMessage)
            : EmailResult.Failed(response.StatusMessage);
    }
}