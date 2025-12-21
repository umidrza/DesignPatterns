namespace DesignPatterns.Behavioral.Visitor;

public interface ICartItem
{
    string Name { get; }
    void Accept(ICartVisitor visitor);
}