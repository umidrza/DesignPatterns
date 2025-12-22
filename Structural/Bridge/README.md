# Bridge (Structural)

Bridge separates an abstraction from its implementation so that both
can change independently.

This example avoids subclass explosion like:
AlertEmail, AlertSms, ReminderEmail, ReminderSms, ...

## Roles
- Abstraction: Notification
- Refined Abstractions: AlertNotification, ReminderNotification
- Implementor interface: INotificationSender
- Concrete Implementors: EmailSender, SmsSender

## When to use
- You have two orthogonal dimensions that vary independently
- You want to avoid deep inheritance hierarchies
- You want runtime switching of implementations

## Key idea
The abstraction *has* an implementation (composition),
instead of *being* the implementation (inheritance).
