namespace DesignPatterns.Behavioral.Strategy.Strategies;

public sealed class PercentageDiscountStrategy : IDiscountStrategy
{
    private readonly decimal _percent;

    public PercentageDiscountStrategy(decimal percent)
    {
        if (percent < 0 || percent > 100)
            throw new ArgumentOutOfRangeException(nameof(percent));

        _percent = percent;
    }

    public decimal Apply(decimal price)
        => price - (price * _percent / 100m);
}
