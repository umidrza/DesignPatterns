namespace DesignPatterns.Behavioral.State.States;

public sealed class PaidState : IOrderState
{
    public string Name => "Paid";

    public void AddItem(Order order, string sku, int quantity)
        => throw new InvalidOperationException("Cannot modify items after payment.");

    public void Submit(Order order)
        => throw new InvalidOperationException("Order is already submitted.");

    public void Pay(Order order, decimal amount)
        => throw new InvalidOperationException("Order is already paid (example keeps it simple).");

    public void Ship(Order order)
        => order.TransitionTo(new ShippedState());

    public void Cancel(Order order, string reason)
        => throw new InvalidOperationException("Cannot cancel after payment in this simplified flow.");
}