namespace DesignPatterns.Structural.Flyweight;

public sealed class TileFlyweight : ITileFlyweight
{
    public TileType Type { get; }

    public TileFlyweight(TileType type)
        => Type = type;

    public void Draw(int x, int y)
    {
        // Real engines would draw sprites; we print for demo
        Console.WriteLine($"Draw {Type.Terrain} '{Type.Symbol}' at ({x},{y}) cost={Type.MoveCost}");
    }
}