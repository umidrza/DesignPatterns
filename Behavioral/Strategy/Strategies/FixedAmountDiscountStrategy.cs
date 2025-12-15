namespace DesignPatterns.Behavioral.Strategy.Strategies;

public sealed class FixedAmountDiscountStrategy : IDiscountStrategy
{
    private readonly decimal _amount;

    public FixedAmountDiscountStrategy(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(amount);

        _amount = amount;
    }

    public decimal Apply(decimal price)
        => Math.Max(0, price - _amount);
}