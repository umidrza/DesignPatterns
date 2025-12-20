namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers;

public sealed class PlaceOrderHandler : Handler
{
    protected override Response? TryHandle(RequestContext context)
    {
        if (context.Path != "/orders/place")
            return null; // not responsible

        var sku = context.Body["sku"];
        var quantity = int.Parse(context.Body["quantity"]);

        // Simulated business logic
        return Response.Ok($"Order placed: SKU={sku}, Qty={quantity}.");
    }
}