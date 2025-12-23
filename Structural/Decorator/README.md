# Decorator (Structural)

Decorator attaches additional responsibilities to an object dynamically.
It provides a flexible alternative to subclassing for extending behavior.

This example decorates a notification sender with cross-cutting concerns:
logging, retry, and encryption.

## Roles
- Component: INotificationSender
- Concrete Component: EmailSender
- Decorator base: NotificationSenderDecorator
- Concrete Decorators: LoggingDecorator, RetryDecorator, EncryptionDecorator

## When to use
- You want to add behavior at runtime
- You want to avoid subclass explosion
- You need flexible combinations of features

## Key idea
Decorators wrap objects that share the same interface.
Each decorator adds behavior before/after delegating to the wrapped object.
