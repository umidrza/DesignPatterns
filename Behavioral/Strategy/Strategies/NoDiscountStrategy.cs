namespace DesignPatterns.Behavioral.Strategy.Strategies;

public sealed class NoDiscountStrategy : IDiscountStrategy
{
    public decimal Apply(decimal price) => price;
}