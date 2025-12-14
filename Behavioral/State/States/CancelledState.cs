namespace DesignPatterns.Behavioral.State.States;

public sealed class CancelledState : IOrderState
{
    public string Name => "Cancelled";

    public void AddItem(Order order, string sku, int quantity)
        => throw new InvalidOperationException("Cannot modify a cancelled order.");

    public void Submit(Order order)
        => throw new InvalidOperationException("Cannot submit a cancelled order.");

    public void Pay(Order order, decimal amount)
        => throw new InvalidOperationException("Cannot pay a cancelled order.");

    public void Ship(Order order)
        => throw new InvalidOperationException("Cannot ship a cancelled order.");

    public void Cancel(Order order, string reason)
        => throw new InvalidOperationException("Order is already cancelled.");
}