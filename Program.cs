using DesignPatterns.Structural.Flyweight;

var factory = new TileFactory();

// Shared tile types (intrinsic state)
var grass = new TileType("Grass", MoveCost: 1, Symbol: '.');
var water = new TileType("Water", MoveCost: 5, Symbol: '~');
var mountain = new TileType("Mountain", MoveCost: 9, Symbol: '^');

var width = 10;
var height = 6;

var grid = new MapGrid(width, height);

for (int y = 0; y < height; y++)
{
    for (int x = 0; x < width; x++)
    {
        // Create a pattern:
        // - water river in middle
        // - mountains on top row edges
        // - else grass
        TileType type =
            (x == 4 && y >= 1) ? water :
            (y == 0 && (x == 0 || x == width - 1)) ? mountain :
            grass;

        var flyweight = factory.Get(type);
        grid.SetCell(new TileCell(x, y, flyweight));
    }
}

Console.WriteLine("ASCII map:");
Console.WriteLine(grid.PrintAscii());

Console.WriteLine($"Flyweights created: {factory.CacheSize} (should be 3)\n");

// Render a few cells (shows same flyweight used in many places)
Console.WriteLine("Rendering sample cells:");
grid.GetCell(0, 0).Render();
grid.GetCell(4, 3).Render();
grid.GetCell(2, 5).Render();
