# Visitor (Behavioral)

Visitor lets you define new operations over an object structure
without modifying the classes of the elements.

This example models a shopping cart with multiple item types.
We add new behaviors (pricing, receipt generation) by creating visitors.

## Roles
- Element interface: defines Accept (ICartItem)
- Concrete elements: PhysicalItem, DigitalItem, SubscriptionItem
- Visitor interface: declares Visit overloads (ICartVisitor)
- Concrete visitors: PriceVisitor, ReceiptVisitor

## When to use
- You have a stable set of element types
- You need to add many different operations (reports, exports, rules)
- You want to keep operations separated from the data model

## Key idea
Double dispatch: Accept calls visitor.Visit(this) so the correct Visit overload runs.
