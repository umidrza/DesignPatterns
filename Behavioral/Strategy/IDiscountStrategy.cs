namespace DesignPatterns.Behavioral.Strategy;

public interface IDiscountStrategy
{
    decimal Apply(decimal price);
}