namespace DesignPatterns.Structural.Adapter.ThirdParty;

// Simulates a vendor SDK you cannot modify
public sealed class ThirdPartyMailer
{
    public ThirdPartyMailResponse SendMail(ThirdPartyMailRequest request)
    {
        // Dummy rules
        if (!request.Recipient.Contains("@"))
        {
            return new ThirdPartyMailResponse
            {
                Ok = false,
                StatusMessage = "Invalid email address."
            };
        }

        return new ThirdPartyMailResponse
        {
            Ok = true,
            MessageId = $"MSG-{Guid.NewGuid():N}"[..12],
            StatusMessage = "Email accepted by provider."
        };
    }
}