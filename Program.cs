using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Adapter.Email_Senders;
using DesignPatterns.Structural.Adapter.ThirdParty;

var welcome = new EmailMessage(
    to: "user@example.com",
    subject: "Welcome",
    body: "<h1>Hello!</h1><p>Thanks for joining.</p>"
);

Console.WriteLine("=== Using Third-Party Adapter ===");
IEmailSender thirdParty = new ThirdPartyEmailSender(new ThirdPartyMailer());
Console.WriteLine(thirdParty.Send(welcome));

Console.WriteLine("\n=== Using Custom SMTP Sender ===");
IEmailSender custom = new SmtpEmailSender();
Console.WriteLine(custom.Send(welcome));

Console.WriteLine("\n=== Custom sender invalid email ===");
var bad = new EmailMessage("invalid", "Test", "Hi");
Console.WriteLine(custom.Send(bad));