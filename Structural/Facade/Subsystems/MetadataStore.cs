using DesignPatterns.Structural.Facade.Models;

namespace DesignPatterns.Structural.Facade.Subsystems;

public sealed class MetadataStore
{
    public string Save(UploadRequest request, string mp4File, string thumbnailFile)
    {
        // Simulate persisting metadata and returning id
        return $"VID-{Guid.NewGuid():N}"[..12];
    }
}