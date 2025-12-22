namespace DesignPatterns.Structural.Flyweight;

// Context: extrinsic state + reference to shared flyweight
public sealed class TileCell
{
    public int X { get; }
    public int Y { get; }
    public ITileFlyweight Tile { get; }

    public TileCell(int x, int y, ITileFlyweight tile)
    {
        X = x;
        Y = y;
        Tile = tile;
    }

    public void Render() => Tile.Draw(X, Y);

    public override string ToString() => Tile.Type.Symbol.ToString();
}