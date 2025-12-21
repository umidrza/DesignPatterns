namespace DesignPatterns.Structural.Composite;

public sealed class Product : IItem
{
    public string Name { get; }
    private readonly decimal _price;

    public Product(string name, decimal price)
    {
        Name = name.Trim();
        _price = price;
    }

    public decimal GetPrice() => _price;

    public string Print(int indent = 0)
        => $"{new string(' ', indent)}- {Name}: {_price:0.00}";
}