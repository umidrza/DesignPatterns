using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Behavioral.Visitor.Items;
using DesignPatterns.Behavioral.Visitor.Visitors;

var cart = new List<ICartItem>
{
    new PhysicalItem("Keyboard", unitPrice: 80m, quantity: 1, weightKg: 1.2m),
    new DigitalItem("IDE License", price: 49.99m, licenseKey: "LIC-7F3A-2K9D"),
    new SubscriptionItem("Cloud Storage", monthlyPrice: 9.99m, months: 6),
    new PhysicalItem("Monitor", unitPrice: 220m, quantity: 2, weightKg: 3.8m)
};

// Visitor 1: pricing
var pricing = new PriceVisitor();
foreach (var item in cart)
    item.Accept(pricing);

Console.WriteLine("Pricing summary:");
Console.WriteLine(pricing);
Console.WriteLine();

// Visitor 2: receipt
var receipt = new ReceiptVisitor();
foreach (var item in cart)
    item.Accept(receipt);

Console.WriteLine("Receipt:");
Console.WriteLine(receipt.Receipt);