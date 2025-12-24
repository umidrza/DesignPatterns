using DesignPatterns.Creational.Builder;

var request = new HttpRequestBuilder()
    .WithMethod("POST")
    .WithUrl("https://api.example.com/orders")
    .WithBearerToken("token-123")
    .AddQuery("expand", "items")
    .AddHeader("X-Client", "web")
    .WithJsonBody("""{ "sku": "A1", "quantity": 2 }""")
    .Build();

Console.WriteLine(request);
Console.WriteLine("Final URI: " + request.BuildFinalUri());
