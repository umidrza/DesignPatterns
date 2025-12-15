using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.Strategy.Strategies;

var price = 100m;
var context = new DiscountContext(new NoDiscountStrategy());

Console.WriteLine(context.GetFinalPrice(price)); // 100

context.ChangeStrategy(new PercentageDiscountStrategy(10));
Console.WriteLine(context.GetFinalPrice(price)); // 90

context.ChangeStrategy(new FixedAmountDiscountStrategy(25));
Console.WriteLine(context.GetFinalPrice(price)); // 75
