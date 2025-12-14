namespace DesignPatterns.Behavioral.State.States;

public sealed class SubmittedState : IOrderState
{
    public string Name => "Submitted";

    public void AddItem(Order order, string sku, int quantity)
        => throw new InvalidOperationException("Cannot modify items after submission.");

    public void Submit(Order order)
        => throw new InvalidOperationException("Order is already submitted.");

    public void Pay(Order order, decimal amount)
    {
        order.RecordPayment(amount);
        order.TransitionTo(new PaidState());
    }

    public void Ship(Order order)
        => throw new InvalidOperationException("Must be paid before shipping.");

    public void Cancel(Order order, string reason)
    {
        order.SetCancellation(reason);
        order.TransitionTo(new CancelledState());
    }
}