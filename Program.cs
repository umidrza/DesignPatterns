using DesignPatterns.Behavioral.Iterator;

var library = new BookCollection();
library.Add(new Book("Clean Code"));
library.Add(new Book("Design Patterns"));
library.Add(new Book("Refactoring"));

var iterator = library.CreateIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}