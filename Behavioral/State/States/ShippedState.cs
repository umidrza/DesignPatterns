namespace DesignPatterns.Behavioral.State.States;

public sealed class ShippedState : IOrderState
{
    public string Name => "Shipped";

    public void AddItem(Order order, string sku, int quantity)
        => throw new InvalidOperationException("Cannot modify a shipped order.");

    public void Submit(Order order)
        => throw new InvalidOperationException("Order is already shipped.");

    public void Pay(Order order, decimal amount)
        => throw new InvalidOperationException("Order is already shipped.");

    public void Ship(Order order)
        => throw new InvalidOperationException("Order is already shipped.");

    public void Cancel(Order order, string reason)
        => throw new InvalidOperationException("Cannot cancel a shipped order.");
}