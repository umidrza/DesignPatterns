using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.ChainOfResponsibility.Handlers;

static Handler BuildPipeline()
{
    var auth = new AuthenticationHandler();
    var rate = new RateLimitHandler(limit: 2, window: TimeSpan.FromSeconds(10));
    var validation = new ValidationHandler();
    var endpoint = new PlaceOrderHandler();

    auth.SetNext(rate).SetNext(validation).SetNext(endpoint);
    return auth;
}

static RequestContext PlaceOrder(string clientId, string? token, string sku, string quantity)
{
    var ctx = new RequestContext("/orders/place", clientId, token);
    ctx.Body["sku"] = sku;
    ctx.Body["quantity"] = quantity;
    return ctx;
}

var pipeline = BuildPipeline();

Console.WriteLine("Case 1: Missing token");
Console.WriteLine(pipeline.Handle(PlaceOrder("client-1", null, "A1", "2")));
Console.WriteLine();

Console.WriteLine("Case 2: Valid token but invalid body");
Console.WriteLine(pipeline.Handle(PlaceOrder("client-1", "valid-token", "", "2")));
Console.WriteLine();

Console.WriteLine("Case 3: Success");
Console.WriteLine(pipeline.Handle(PlaceOrder("client-1", "valid-token", "A1", "2")));
Console.WriteLine();

Console.WriteLine("Case 4: Rate limit exceeded (same client, quick calls)");
Console.WriteLine(pipeline.Handle(PlaceOrder("client-1", "valid-token", "B7", "1")));
Console.WriteLine(pipeline.Handle(PlaceOrder("client-1", "valid-token", "C9", "1")));
