using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Decorator.Decorators;

// Base component
INotificationSender sender = new EmailSender();

// Wrap with decorators (order matters!)
sender =
    new LoggingDecorator(
        new RetryDecorator(
            new EncryptionDecorator(sender),
            maxRetries: 3
        )
    );

sender.Send("user@example.com", "Hello Decorator Pattern!");
