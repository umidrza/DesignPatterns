namespace DesignPatterns.Behavioral.Visitor.Items;

public sealed class PhysicalItem : ICartItem
{
    public string Name { get; }
    public decimal UnitPrice { get; }
    public int Quantity { get; }
    public decimal WeightKg { get; }

    public PhysicalItem(string name, decimal unitPrice, int quantity, decimal weightKg)
    {
        Name = name;
        UnitPrice = unitPrice;
        Quantity = quantity;
        WeightKg = weightKg;
    }

    public void Accept(ICartVisitor visitor) => visitor.Visit(this);
}