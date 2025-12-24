namespace DesignPatterns.Creational.Prototype;

public sealed class Page
{
    public string Title { get; }
    public string Content { get; }

    public Page(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public Page Clone()
        => new Page(Title, Content);
}