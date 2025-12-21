namespace DesignPatterns.Behavioral.Visitor.Items;

public sealed class DigitalItem : ICartItem
{
    public string Name { get; }
    public decimal Price { get; }
    public string LicenseKey { get; }

    public DigitalItem(string name, decimal price, string licenseKey)
    {
        Name = name;
        Price = price;
        LicenseKey = licenseKey;
    }

    public void Accept(ICartVisitor visitor) => visitor.Visit(this);
}