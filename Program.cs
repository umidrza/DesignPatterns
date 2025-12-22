using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Bridge.Notifications;
using DesignPatterns.Structural.Bridge.Senders;

INotificationSender email = new EmailSender();
INotificationSender sms = new SmsSender();

Notification alertByEmail = new AlertNotification(email);
Notification alertBySms = new AlertNotification(sms);

Notification reminderByEmail = new ReminderNotification(email);
Notification reminderBySms = new ReminderNotification(sms);

alertByEmail.Notify("user@example.com", "System overload");
alertBySms.Notify("+123456789", "System overload");

reminderByEmail.Notify("user@example.com", "Stand-up meeting at 10 AM");
reminderBySms.Notify("+123456789", "Stand-up meeting at 10 AM");