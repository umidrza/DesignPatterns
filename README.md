# Design Patterns in C#

A comprehensive collection of **Gang of Four (GoF) Design Patterns** implemented in **C#**, using clean, realistic, production-style examples.

This repository is designed for:
- learning design patterns deeply
- interview preparation
- practical reference for real projects

---

Each pattern folder contains:
- a complete, runnable C# example
- a focused implementation illustrating the pattern’s intent

---

## Covered Patterns

### Creational
- **Singleton** – Ensure a single shared instance
- **Factory Method** – Delegate object creation to subclasses
- **Abstract Factory** – Create families of related objects
- **Builder** – Construct complex objects step by step
- **Prototype** – Clone existing objects

### Structural
- **Adapter** – Make incompatible interfaces work together
- **Bridge** – Decouple abstraction from implementation
- **Composite** – Treat objects and compositions uniformly
- **Decorator** – Add behavior dynamically
- **Facade** – Simplify interaction with complex subsystems
- **Flyweight** – Share intrinsic state to reduce memory usage
- **Proxy** – Control access to another object

### Behavioral
- **Chain of Responsibility** – Pass requests through handlers
- **Command** – Encapsulate actions as objects
- **Interpreter** – Define and evaluate grammar rules
- **Iterator** – Traverse collections safely
- **Mediator** – Centralize complex communication
- **Memento** – Capture and restore state
- **Observer** – Notify dependents of changes
- **State** – Change behavior based on state
- **Strategy** – Swap algorithms at runtime
- **Template Method** – Define algorithm skeletons
- **Visitor** – Add operations without modifying structures

---

## Design Principles Applied

- SOLID principles
- Composition over inheritance
- Clear separation of concerns
- Minimal coupling and explicit dependencies
- Interfaces and abstractions used intentionally
- `sealed` used for concrete, non-extensible roles

---

## Code Style

- Modern C# (C# 10+)
- Clear domain-driven naming
- Immutable value objects where appropriate
- No static helper abuse
- No frameworks unless required by the pattern

---

## How to Use

### Learning
1. Start with **Creational → Structural → Behavioral**
2. Understand the intent of each pattern
3. Study the implementation
4. Compare similar patterns (e.g., Strategy vs State)

### Interview Preparation
- Know **why** the pattern exists
- Know **when not** to use it
- Be able to explain trade-offs and alternatives

### Real Projects
- Use patterns as templates
- Adapt the domain and naming
- Combine patterns when appropriate (e.g., Facade + Adapter)

---

## Notes

- Patterns are implemented for **clarity and correctness**
- Examples are **realistic**, not academic-only
- Overengineering and “pattern for pattern’s sake” are avoided

---

> **Design patterns are tools, not goals.**  
> This repository helps you understand *when and why* to use them correctly.
