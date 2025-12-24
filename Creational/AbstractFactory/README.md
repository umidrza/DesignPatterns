# Abstract Factory (Creational)

Abstract Factory provides an interface for creating families of related
or dependent objects without specifying their concrete classes.

This example demonstrates a UI toolkit that can switch themes
(light or dark) while keeping components consistent.

## Roles
- Abstract Factory: IUIFactory
- Concrete Factories: LightUIFactory, DarkUIFactory
- Abstract Products: IButton, ICheckbox
- Concrete Products: LightButton, DarkButton, LightCheckbox, DarkCheckbox

## When to use
- You need to create families of related objects
- You want to ensure compatibility between objects
- You want to switch product families at runtime

## Key idea
One factory creates a whole family of objects that belong together.
