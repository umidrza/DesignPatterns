namespace DesignPatterns.Structural.Composite;

public interface IItem
{
    string Name { get; }
    decimal GetPrice();
    string Print(int indent = 0);
}