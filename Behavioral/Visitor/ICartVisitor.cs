using DesignPatterns.Behavioral.Visitor.Items;

namespace DesignPatterns.Behavioral.Visitor;

public interface ICartVisitor
{
    void Visit(PhysicalItem item);
    void Visit(DigitalItem item);
    void Visit(SubscriptionItem item);
}