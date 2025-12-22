namespace DesignPatterns.Structural.Facade.Models;

public sealed class UploadResult
{
    public bool Success { get; }
    public string VideoId { get; }
    public string Message { get; }

    private UploadResult(bool success, string videoId, string message)
    {
        Success = success;
        VideoId = videoId;
        Message = message;
    }

    public static UploadResult Ok(string videoId, string message)
        => new(true, videoId, message);

    public static UploadResult Failed(string message)
        => new(false, "", message);

    public override string ToString()
        => Success ? $"OK VideoId={VideoId} - {Message}" : $"FAILED - {Message}";
}