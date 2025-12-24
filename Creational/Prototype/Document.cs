namespace DesignPatterns.Creational.Prototype;

public sealed class Document : IPrototype<Document>
{
    public string Name { get; private set; }
    private readonly List<Page> _pages = new();

    public IReadOnlyList<Page> Pages => _pages;

    public Document(string name)
    {
        Name = name.Trim();
    }

    public void Rename(string name)
        => Name = name;

    public void AddPage(Page page)
        => _pages.Add(page);

    // Deep clone
    public Document Clone()
    {
        var copy = new Document(Name);

        foreach (var page in _pages)
            copy.AddPage(page.Clone());

        return copy;
    }
}