# Flyweight (Structural)

Flyweight reduces memory consumption by sharing immutable data
between a large number of fine-grained objects.

This example models a large map:
- Intrinsic (shared): tile type data (Terrain name, move cost, symbol)
- Extrinsic (per-cell): position (x,y) and which tile type is used there

## Roles
- Flyweight interface: operations using extrinsic data (ITileFlyweight)
- Concrete flyweight: stores intrinsic state (TileFlyweight)
- Flyweight factory: caches and reuses flyweights (TileFactory)
- Context: per-cell data referencing flyweight (TileCell)

## When to use
- Huge numbers of similar objects
- Memory pressure from duplicated data
- Intrinsic state can be made immutable

## Key idea
Thousands of cells can reuse a small set of tile flyweights.
