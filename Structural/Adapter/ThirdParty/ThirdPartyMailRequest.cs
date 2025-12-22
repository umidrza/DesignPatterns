namespace DesignPatterns.Structural.Adapter.ThirdParty;

public sealed class ThirdPartyMailRequest
{
    public string Recipient { get; init; } = "";
    public string Title { get; init; } = "";
    public string HtmlBody { get; init; } = "";
}