namespace DesignPatterns.Structural.Proxy;

public sealed class RealDocument : IDocument
{
    private readonly string _path;
    private string? _content;

    public RealDocument(string path)
    {
        _path = path;
        LoadFromDisk();
    }

    private void LoadFromDisk()
    {
        // Simulate expensive IO
        Console.WriteLine($"[RealDocument] Loading '{_path}' from disk...");
        Thread.Sleep(500);
        _content = $"Sensitive content of {_path}";
    }

    public string GetContent()
        => _content!;
}