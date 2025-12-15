# Strategy (Behavioral)

Strategy lets you define multiple interchangeable algorithms behind a common interface.
The client chooses (or switches) the algorithm at runtime.

## Roles
- Strategy: common interface for algorithms
- Concrete Strategies: different implementations
- Context: uses a strategy to do work

## When to use
- You have multiple ways to do the same thing
- You want to avoid large if/else or switch blocks
- You want to swap behavior at runtime or via DI/config

