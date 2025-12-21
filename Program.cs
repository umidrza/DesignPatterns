using DesignPatterns.Structural.Composite;

IItem keyboard = new Product("Keyboard", 80m);
IItem mouse = new Product("Mouse", 25m);
IItem monitor = new Product("Monitor", 220m);

var workSetup = new Bundle("Work Setup")
    .Add(keyboard)
    .Add(mouse);

var fullOffice = new Bundle("Full Office")
    .Add(workSetup)
    .Add(monitor)
    .Add(new Product("Webcam", 55m));

Console.WriteLine(fullOffice.Print());
Console.WriteLine();
Console.WriteLine($"Total price: {fullOffice.GetPrice():0.00}");
