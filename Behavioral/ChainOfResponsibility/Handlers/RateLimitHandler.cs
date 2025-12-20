namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers;

public sealed class RateLimitHandler : Handler
{
    private readonly Dictionary<string, (DateTime windowStart, int count)> _hits = new();
    private readonly int _limit;
    private readonly TimeSpan _window;

    public RateLimitHandler(int limit, TimeSpan window)
    {
        _limit = limit;
        _window = window;
    }

    protected override Response? TryHandle(RequestContext context)
    {
        var now = DateTime.UtcNow;

        if (!_hits.TryGetValue(context.ClientId, out var entry) ||
            now - entry.windowStart >= _window)
        {
            _hits[context.ClientId] = (now, 1);
            return null;
        }

        var newCount = entry.count + 1;
        _hits[context.ClientId] = (entry.windowStart, newCount);

        if (newCount > _limit)
            return Response.TooManyRequests($"Rate limit exceeded: {_limit} per {_window.TotalSeconds:0}s.");

        return null;
    }
}
