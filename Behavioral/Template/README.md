# Template Method (Behavioral)

Template Method defines the skeleton of an algorithm in a base class,
deferring some steps to subclasses.

## Roles
- Abstract Class: defines the template method (DocumentGenerator)
- Template Method: fixed algorithm (Generate)
- Primitive Operations: steps overridden by subclasses
- Hooks: optional extension points

## When to use
- The overall process must not change
- Certain steps vary by implementation
- You want to avoid duplicating workflow logic

## Key idea
The algorithm structure is locked.
Subclasses can customize behavior only through predefined steps.
