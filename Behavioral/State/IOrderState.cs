namespace DesignPatterns.Behavioral.State;

public interface IOrderState
{
    string Name { get; }

    void AddItem(Order order, string sku, int quantity);
    void Submit(Order order);
    void Pay(Order order, decimal amount);
    void Ship(Order order);
    void Cancel(Order order, string reason);
}