# Prototype (Creational)

Prototype creates new objects by copying an existing object (the prototype).
The clone can then be modified independently.

This example demonstrates document templates:
- a base document is created once
- new documents are cloned from it
- deep cloning ensures independence

## Roles
- Prototype interface: declares Clone (IPrototype)
- Concrete prototype: implements cloning (Document)
- Client: clones prototypes instead of instantiating new objects

## When to use
- Object creation is expensive
- You want to avoid complex constructors
- You need copies without coupling to concrete classes

## Key idea
Clone objects instead of rebuilding them.
Deep clone when objects contain mutable references.
