namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public sealed class RequestContext
{
    public string Path { get; }
    public string? AuthToken { get; }
    public string ClientId { get; }

    public Dictionary<string, string> Body { get; } = new();

    public RequestContext(string path, string clientId, string? authToken)
    {
        if (string.IsNullOrWhiteSpace(path)) throw new ArgumentException("Path is required.", nameof(path));
        if (string.IsNullOrWhiteSpace(clientId)) throw new ArgumentException("ClientId is required.", nameof(clientId));

        Path = path.Trim();
        ClientId = clientId.Trim();
        AuthToken = authToken;
    }
}