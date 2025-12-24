namespace DesignPatterns.Creational.Builder;

public sealed class HttpRequestBuilder
{
    private string? _method;
    private Uri? _url;
    private readonly Dictionary<string, string> _headers = new(StringComparer.OrdinalIgnoreCase);
    private readonly Dictionary<string, string> _query = new(StringComparer.OrdinalIgnoreCase);
    private string? _body;

    public HttpRequestBuilder WithMethod(string method)
    {
        _method = method.Trim().ToUpperInvariant();
        return this;
    }

    public HttpRequestBuilder WithUrl(string url)
    {
        if (!Uri.TryCreate(url, UriKind.Absolute, out var uri))
            throw new ArgumentException("Url must be an absolute URI.", nameof(url));

        _url = uri;
        return this;
    }

    public HttpRequestBuilder AddHeader(string key, string value)
    {
        _headers[key.Trim()] = value ?? "";
        return this;
    }

    public HttpRequestBuilder AddQuery(string key, string value)
    {
        _query[key.Trim()] = value ?? "";
        return this;
    }

    public HttpRequestBuilder WithJsonBody(string json)
    {
        _body = json;
        AddHeader("Content-Type", "application/json");
        return this;
    }

    public HttpRequestBuilder WithBearerToken(string token)
    {
        AddHeader("Authorization", $"Bearer {token.Trim()}");
        return this;
    }

    public HttpRequest Build()
    {
        if (_method is null) throw new InvalidOperationException("Method is required. Call WithMethod().");
        if (_url is null) throw new InvalidOperationException("Url is required. Call WithUrl().");

        // Create copies so built request is immutable
        return new HttpRequest(
            method: _method,
            url: _url,
            headers: new Dictionary<string, string>(_headers, StringComparer.OrdinalIgnoreCase),
            query: new Dictionary<string, string>(_query, StringComparer.OrdinalIgnoreCase),
            body: _body
        );
    }
}