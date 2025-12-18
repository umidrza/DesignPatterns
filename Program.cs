using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Observer.Observers;

var stock = new Stock("ACME", 95m);

var trader = new TraderDisplayObserver(stock);
var alert = new PriceAlertObserver(stock, 100m);

stock.Attach(trader);
stock.Attach(alert);

stock.UpdatePrice(97m);
stock.UpdatePrice(101m);
