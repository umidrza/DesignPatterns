using DesignPatterns.Structural.Proxy;

var admin = new UserContext("Alice", isAdmin: true);
var user = new UserContext("Bob", isAdmin: false);

IDocument adminDoc = new SecureDocumentProxy("secret.txt", admin);
IDocument userDoc = new SecureDocumentProxy("secret.txt", user);

Console.WriteLine("Admin access:");
Console.WriteLine(adminDoc.GetContent());

try
{
    Console.WriteLine("\nUser access:");
    Console.WriteLine(userDoc.GetContent());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
