namespace DesignPatterns.Structural.Facade.Models;

public sealed class UploadRequest
{
    public string FileName { get; }
    public string UploaderId { get; }
    public string Title { get; }

    public UploadRequest(string fileName, string uploaderId, string title)
    {
        FileName = fileName.Trim();
        UploaderId = uploaderId.Trim();
        Title = title.Trim();
    }
}