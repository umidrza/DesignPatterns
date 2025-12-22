namespace DesignPatterns.Structural.Facade.Subsystems;

public sealed class VirusScanner
{
    public bool IsClean(string fileName)
    {
        // Dummy rule: suspicious file names fail
        if (fileName.Contains("virus", StringComparison.OrdinalIgnoreCase))
            return false;

        return true;
    }
}