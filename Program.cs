using DesignPatterns.Behavioral.State;

static void Try(string label, Action action)
{
    Console.Write($"{label,-28} ");
    try
    {
        action();
        Console.WriteLine("OK");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
    }
}

var order = new Order();

Console.WriteLine(order);
Console.WriteLine();

Try("AddItem(A1 x2)", () => order.AddItem("A1", 2));
Try("AddItem(B7 x1)", () => order.AddItem("B7", 1));
Console.WriteLine(order);
Console.WriteLine();

Try("Pay(20) before submit", () => order.Pay(20m));
Try("Submit()", () => order.Submit());
Console.WriteLine(order);
Console.WriteLine();


Try("AddItem after submit", () => order.AddItem("X9", 1));
Try("Pay(50)", () => order.Pay(50m));
Console.WriteLine(order);
Console.WriteLine();


Try("Cancel after paid", () => order.Cancel("Customer changed mind"));
Try("Ship()", () => order.Ship());
Console.WriteLine(order);
Console.WriteLine();


Try("Ship again", () => order.Ship());
Try("Cancel shipped", () => order.Cancel("Too late"));
Console.WriteLine(order);
Console.WriteLine();

