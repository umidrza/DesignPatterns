namespace DesignPatterns.Structural.Adapter;

public sealed class EmailResult
{
    public bool Success { get; }
    public string ProviderMessageId { get; }
    public string Message { get; }

    private EmailResult(bool success, string providerMessageId, string message)
    {
        Success = success;
        ProviderMessageId = providerMessageId;
        Message = message;
    }

    public static EmailResult Sent(string providerMessageId, string message)
        => new(true, providerMessageId, message);

    public static EmailResult Failed(string message)
        => new(false, "", message);

    public override string ToString()
        => Success
            ? $"SENT (Id={ProviderMessageId}) - {Message}"
            : $"FAILED - {Message}";
}