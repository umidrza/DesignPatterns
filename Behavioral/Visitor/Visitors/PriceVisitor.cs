using DesignPatterns.Behavioral.Visitor.Items;

namespace DesignPatterns.Behavioral.Visitor.Visitors;

public sealed class PriceVisitor : ICartVisitor
{
    public decimal Subtotal { get; private set; }
    public decimal Tax { get; private set; }
    public decimal Shipping { get; private set; }

    // Simple rules for demo:
    // - Physical items: 10% tax + shipping based on weight
    // - Digital items: 5% tax, no shipping
    // - Subscriptions: 0% tax, no shipping (simplified)

    public void Visit(PhysicalItem item)
    {
        var line = item.UnitPrice * item.Quantity;
        Subtotal += line;

        Tax += line * 0.10m;

        // shipping: base + weight factor
        var totalWeight = item.WeightKg * item.Quantity;
        Shipping += 3m + (totalWeight * 1.25m);
    }

    public void Visit(DigitalItem item)
    {
        Subtotal += item.Price;
        Tax += item.Price * 0.05m;
    }

    public void Visit(SubscriptionItem item)
    {
        Subtotal += item.MonthlyPrice * item.Months;
        // tax/shipping omitted by rule
    }

    public decimal Total => Math.Round(Subtotal + Tax + Shipping, 2);

    public override string ToString()
        => $"Subtotal={Subtotal:0.00}, Tax={Tax:0.00}, Shipping={Shipping:0.00}, Total={Total:0.00}";
}