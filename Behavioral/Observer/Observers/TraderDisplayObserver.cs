namespace DesignPatterns.Behavioral.Observer.Observers;

public sealed class TraderDisplayObserver : IObserver
{
    public Stock Stock { get; set; }
    public TraderDisplayObserver(Stock stock)
    {
        Stock = stock;
    }

    public void Update()
    {
        Console.WriteLine($"[Trader] {Stock.Symbol}: {Stock.GetPrice():0.00}");
    }
}