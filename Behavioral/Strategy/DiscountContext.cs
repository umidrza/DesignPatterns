namespace DesignPatterns.Behavioral.Strategy;

public sealed class DiscountContext
{
    private IDiscountStrategy _strategy;

    public DiscountContext(IDiscountStrategy strategy)
        => _strategy = strategy;

    public void ChangeStrategy(IDiscountStrategy strategy)
        => _strategy = strategy;

    public decimal GetFinalPrice(decimal price)
        => _strategy.Apply(price);
}