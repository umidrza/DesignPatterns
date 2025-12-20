namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers;

public sealed class ValidationHandler : Handler
{
    protected override Response? TryHandle(RequestContext context)
    {
        if (context.Path == "/orders/place")
        {
            if (!context.Body.TryGetValue("sku", out var sku) || string.IsNullOrWhiteSpace(sku))
                return Response.BadRequest("Body.sku is required.");

            if (!context.Body.TryGetValue("quantity", out var q) ||
                !int.TryParse(q, out var qty) || qty <= 0)
                return Response.BadRequest("Body.quantity must be a positive integer.");
        }

        return null;
    }
}
