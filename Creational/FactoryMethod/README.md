# Factory Method (Creational)

Factory Method defines an interface for creating objects,
but lets subclasses alter the type of objects that will be created.

This example shows notification creation delegated to specialized creators.

## Roles
- Product: INotification
- Concrete Products: EmailNotification, SmsNotification
- Creator: NotificationCreator
- Concrete Creators: EmailNotificationCreator, SmsNotificationCreator

## When to use
- You don’t know the exact object type at compile time
- Object creation varies by context
- You want to follow Open/Closed Principle

## Key idea
The base class defines *when* an object is created,
subclasses decide *what* object is created.
