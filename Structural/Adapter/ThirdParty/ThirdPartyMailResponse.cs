namespace DesignPatterns.Structural.Adapter.ThirdParty;

public sealed class ThirdPartyMailResponse
{
    public bool Ok { get; init; }
    public string MessageId { get; init; } = "";
    public string StatusMessage { get; init; } = "";
}