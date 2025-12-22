namespace DesignPatterns.Structural.Facade.Subsystems;

public sealed class Transcoder
{
    public string TranscodeToMp4(string fileName)
    {
        // In real life this would return a path to output file.
        return $"{fileName}.mp4";
    }
}