namespace DesignPatterns.Structural.Proxy;

public sealed class SecureDocumentProxy : IDocument
{
    private readonly string _path;
    private readonly UserContext _user;

    private RealDocument? _realDocument;

    public SecureDocumentProxy(string path, UserContext user)
    {
        _path = path;
        _user = user;
    }

    public string GetContent()
    {
        if (!_user.IsAdmin)
            throw new UnauthorizedAccessException("Only admins can read this document.");

        // Lazy initialization
        _realDocument ??= new RealDocument(_path);

        return _realDocument.GetContent();
    }
}