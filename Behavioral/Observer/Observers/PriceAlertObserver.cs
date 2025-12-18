namespace DesignPatterns.Behavioral.Observer.Observers;

public sealed class PriceAlertObserver : IObserver
{
    public Stock Stock { get; set; }
    private readonly decimal _threshold;

    public PriceAlertObserver(Stock stock, decimal threshold)
    {  
        Stock = stock;
        _threshold = threshold; 
    }

    public void Update()
    {
        if (Stock.GetPrice() >= _threshold)
        {
            Console.WriteLine($"[ALERT] {Stock.Symbol} crossed {_threshold:0.00} (now {Stock.GetPrice():0.00})"
);
        }
    }
}