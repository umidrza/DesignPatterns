using System.Text;

namespace DesignPatterns.Structural.Composite;

public sealed class Bundle : IItem
{
    private readonly List<IItem> _items = new();
    public string Name { get; }

    public Bundle(string name)
    {
        Name = name;
    }

    public Bundle Add(IItem item)
    {
        _items.Add(item);
        return this;
    }

    public decimal GetPrice()
    {
        decimal total = 0m;
        foreach (var item in _items)
            total += item.GetPrice();

        return total;
    }

    public string Print(int indent = 0)
    {
        var pad = new string(' ', indent);
        var sb = new StringBuilder();

        sb.AppendLine($"{pad}+ Bundle: {Name} {GetPrice():0.00}");

        foreach (var item in _items)
            sb.AppendLine(item.Print(indent + 2));

        return sb.ToString().TrimEnd();
    }
}