namespace DesignPatterns.Structural.Flyweight;

// Intrinsic state (shared)
public sealed record TileType(
    string Terrain,
    int MoveCost,
    char Symbol
);