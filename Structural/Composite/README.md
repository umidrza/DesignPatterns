# Composite (Structural)

Composite composes objects into tree structures to represent part-whole hierarchies.
It lets clients treat individual objects (leaves) and compositions (composites) uniformly.

This example models a catalog where a bundle can contain:
- products
- other bundles (nested bundles)

## Roles
- Component: common interface (IItem)
- Leaf: single object with no children (Product)
- Composite: object that contains children (Bundle)

## When to use
- You need part-whole trees (menus, folders, UI components)
- You want uniform operations (price, render, print)
- You want recursive composition (a bundle of bundles)

## Key idea
Client code works with IItem and doesn't care if it's a product or a bundle.
