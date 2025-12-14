namespace DesignPatterns.Behavioral.State.States;

public sealed class DraftState : IOrderState
{
    public string Name => "Draft";

    public void AddItem(Order order, string sku, int quantity)
        => order.AddOrIncreaseItem(sku, quantity);

    public void Submit(Order order)
    {
        if (order.Items.Count == 0)
            throw new InvalidOperationException("Cannot submit an empty order.");

        order.TransitionTo(new SubmittedState());
    }

    public void Pay(Order order, decimal amount)
        => throw new InvalidOperationException("Cannot pay a draft order. Submit it first.");

    public void Ship(Order order)
        => throw new InvalidOperationException("Cannot ship a draft order.");

    public void Cancel(Order order, string reason)
    {
        order.SetCancellation(reason);
        order.TransitionTo(new CancelledState());
    }
}