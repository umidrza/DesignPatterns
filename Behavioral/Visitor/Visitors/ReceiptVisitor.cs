using DesignPatterns.Behavioral.Visitor.Items;
using System.Text;

namespace DesignPatterns.Behavioral.Visitor.Visitors;

public sealed class ReceiptVisitor : ICartVisitor
{
    private readonly StringBuilder _sb = new();

    public string Receipt => _sb.ToString();

    public void Visit(PhysicalItem item)
    {
        var lineTotal = item.UnitPrice * item.Quantity;
        _sb.AppendLine($"[Physical] {item.Name} x{item.Quantity} @ {item.UnitPrice:0.00} = {lineTotal:0.00}");
    }

    public void Visit(DigitalItem item)
    {
        _sb.AppendLine($"[Digital ] {item.Name} = {item.Price:0.00} (License: {item.LicenseKey})");
    }

    public void Visit(SubscriptionItem item)
    {
        var total = item.MonthlyPrice * item.Months;
        _sb.AppendLine($"[Subscr ] {item.Name} {item.Months} mo @ {item.MonthlyPrice:0.00} = {total:0.00}");
    }
}