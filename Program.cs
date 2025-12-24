using DesignPatterns.Creational.Prototype;

// Create prototype (template)
var contractTemplate = new Document("Contract Template");
contractTemplate.AddPage(new Page("Intro", "This contract is made between..."));
contractTemplate.AddPage(new Page("Terms", "The parties agree to the following terms..."));

// Clone prototype
var clientAContract = contractTemplate.Clone();
clientAContract.Rename("Contract - Client A");

// Clone again
var clientBContract = contractTemplate.Clone();
clientBContract.Rename("Contract - Client B");

// Modify clone without affecting prototype
clientBContract.AddPage(new Page("Appendix", "Special conditions for Client B"));

Console.WriteLine($"{contractTemplate.Name} pages: {contractTemplate.Pages.Count}");
Console.WriteLine($"{clientAContract.Name} pages: {clientAContract.Pages.Count}");
Console.WriteLine($"{clientBContract.Name} pages: {clientBContract.Pages.Count}");
