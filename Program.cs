using DesignPatterns.Creational.Singleton;

var config = AppConfiguration.Instance;

Console.WriteLine($"Environment: {config.Get("Environment")}");
Console.WriteLine($"MaxItemsPerPage: {config.Get("MaxItemsPerPage")}");
Console.WriteLine($"EnableCaching: {config.Get("EnableCaching")}");

// Same instance everywhere
var configAgain = AppConfiguration.Instance;
Console.WriteLine($"\nSame instance? {ReferenceEquals(config, configAgain)}");

// Snapshot for debugging/logging
Console.WriteLine("\nConfiguration snapshot:");
foreach (var kv in config.Snapshot())
{
    Console.WriteLine($"{kv.Key} = {kv.Value}");
}