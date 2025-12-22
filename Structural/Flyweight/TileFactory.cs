namespace DesignPatterns.Structural.Flyweight;

public sealed class TileFactory
{
    private readonly Dictionary<TileType, ITileFlyweight> _cache = new();

    public ITileFlyweight Get(TileType type)
    {
        if (!_cache.TryGetValue(type, out var flyweight))
        {
            flyweight = new TileFlyweight(type);
            _cache[type] = flyweight;
        }

        return flyweight;
    }

    public int CacheSize => _cache.Count;
}