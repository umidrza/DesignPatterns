namespace DesignPatterns.Structural.Facade.Subsystems;

public sealed class ThumbnailGenerator
{
    public string Generate(string mp4File)
    {
        return $"{mp4File}.thumb.jpg";
    }
}