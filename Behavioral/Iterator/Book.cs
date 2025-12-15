namespace DesignPatterns.Behavioral.Iterator;

public class Book
{
    public string Title { get; }

    public Book(string title)
        => Title = title;

    public override string ToString() => Title;
}