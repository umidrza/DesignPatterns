namespace DesignPatterns.Behavioral.Observer;

public class Stock : Subject
{
    public string Symbol { get; }
    private decimal _price;

    public Stock(string symbol, decimal price)
    {
        Symbol = symbol;
        _price = price;
    }

    public decimal GetPrice()
    {
        return _price; 
    }

    public void UpdatePrice(decimal newPrice)
    {
        if (newPrice <= 0)
            throw new ArgumentOutOfRangeException(nameof(newPrice));

        if (newPrice == _price) return;

        var old = _price;
        _price = newPrice;

        Notify();
    }
}
