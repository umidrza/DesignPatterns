using System.Text;

namespace DesignPatterns.Creational.Builder;

public sealed class HttpRequest
{
    public string Method { get; }
    public Uri Url { get; }
    public IReadOnlyDictionary<string, string> Headers { get; }
    public IReadOnlyDictionary<string, string> Query { get; }
    public string? Body { get; }

    internal HttpRequest(
        string method,
        Uri url,
        Dictionary<string, string> headers,
        Dictionary<string, string> query,
        string? body)
    {
        Method = method;
        Url = url;
        Headers = headers;
        Query = query;
        Body = body;
    }

    public Uri BuildFinalUri()
    {
        if (Query.Count == 0) return Url;

        var sb = new StringBuilder();
        sb.Append(Url.AbsoluteUri);
        sb.Append(Url.Query.Length == 0 ? "?" : "&");

        var first = true;
        foreach (var kv in Query)
        {
            if (!first) sb.Append("&");
            first = false;

            sb.Append(Uri.EscapeDataString(kv.Key));
            sb.Append("=");
            sb.Append(Uri.EscapeDataString(kv.Value));
        }

        return new Uri(sb.ToString());
    }

    public override string ToString()
    {
        var uri = BuildFinalUri();
        return $"{Method} {uri} (Headers={Headers.Count}, Query={Query.Count}, Body={(Body is null ? "none" : "yes")})";
    }
}