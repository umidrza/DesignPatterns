using System.Text;

namespace DesignPatterns.Structural.Flyweight;

public sealed class MapGrid
{
    private readonly TileCell[,] _cells;

    public int Width { get; }
    public int Height { get; }

    public MapGrid(int width, int height)
    {
        Width = width;
        Height = height;
        _cells = new TileCell[width, height];
    }

    public void SetCell(TileCell cell)
    {
        _cells[cell.X, cell.Y] = cell;
    }

    public TileCell GetCell(int x, int y) => _cells[x, y];

    public string PrintAscii()
    {
        var sb = new StringBuilder();

        for (int y = 0; y < Height; y++)
        {
            for (int x = 0; x < Width; x++)
                sb.Append(_cells[x, y].ToString());

            sb.AppendLine();
        }

        return sb.ToString();
    }
}