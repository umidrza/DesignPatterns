using DesignPatterns.Behavioral.State.States;

namespace DesignPatterns.Behavioral.State;

public sealed class Order
{
    private IOrderState _state = new DraftState();

    private readonly Dictionary<string, int> _items = new();
    public IReadOnlyDictionary<string, int> Items => _items;

    public decimal TotalPaid { get; private set; } = 0m;
    public string? CancellationReason { get; private set; }

    public string StateName => _state.Name;

    internal void TransitionTo(IOrderState newState) => _state = newState;

    internal void AddOrIncreaseItem(string sku, int quantity)
    {
        if (string.IsNullOrWhiteSpace(sku)) throw new ArgumentException("SKU is required.", nameof(sku));
        if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be > 0.");

        _items.TryGetValue(sku, out var existing);
        _items[sku] = existing + quantity;
    }

    internal void RecordPayment(decimal amount)
    {
        if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Payment must be > 0.");
        TotalPaid += amount;
    }

    internal void SetCancellation(string reason)
    {
        CancellationReason = string.IsNullOrWhiteSpace(reason) ? "No reason provided." : reason.Trim();
    }

    // Public API delegates to current state:
    public void AddItem(string sku, int quantity) => _state.AddItem(this, sku, quantity);
    public void Submit() => _state.Submit(this);
    public void Pay(decimal amount) => _state.Pay(this, amount);
    public void Ship() => _state.Ship(this);
    public void Cancel(string reason) => _state.Cancel(this, reason);

    public override string ToString()
    {
        var itemCount = 0;
        foreach (var kv in _items) itemCount += kv.Value;

        var cancel = CancellationReason is null ? "" : $" | CancelReason: {CancellationReason}";
        return $"Order(State={StateName}, Items={itemCount}, Paid={TotalPaid:0.00}{cancel})";
    }
}