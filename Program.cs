using DesignPatterns.Creational.FactoryMethod.Creators;

// Choose creator at runtime
NotificationCreator creator;

creator = new EmailNotificationCreator();
creator.Notify("user@example.com", "Welcome via Email!");

creator = new SmsNotificationCreator();
creator.Notify("+123456789", "Welcome via SMS!");
