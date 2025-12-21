namespace DesignPatterns.Behavioral.Visitor.Items;

public sealed class SubscriptionItem : ICartItem
{
    public string Name { get; }
    public decimal MonthlyPrice { get; }
    public int Months { get; }

    public SubscriptionItem(string name, decimal monthlyPrice, int months)
    {
        Name = name;
        MonthlyPrice = monthlyPrice;
        Months = months;
    }

    public void Accept(ICartVisitor visitor) => visitor.Visit(this);
}