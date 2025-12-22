namespace DesignPatterns.Structural.Flyweight;

public interface ITileFlyweight
{
    TileType Type { get; }
    void Draw(int x, int y);
}
