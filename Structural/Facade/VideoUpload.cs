using DesignPatterns.Structural.Facade.Models;
using DesignPatterns.Structural.Facade.Subsystems;

namespace DesignPatterns.Structural.Facade;

public sealed class VideoUpload
{
    private readonly VirusScanner _scanner;
    private readonly Transcoder _transcoder;
    private readonly ThumbnailGenerator _thumbs;
    private readonly MetadataStore _store;

    public VideoUpload(
        VirusScanner scanner,
        Transcoder transcoder,
        ThumbnailGenerator thumbs,
        MetadataStore store)
    {
        _scanner = scanner;
        _transcoder = transcoder;
        _thumbs = thumbs;
        _store = store;
    }

    public UploadResult Upload(UploadRequest request)
    {
        if (!_scanner.IsClean(request.FileName))
            return UploadResult.Failed("Upload rejected: file failed virus scan.");

        var mp4 = _transcoder.TranscodeToMp4(request.FileName);
        var thumb = _thumbs.Generate(mp4);

        var id = _store.Save(request, mp4, thumb);

        return UploadResult.Ok(id, $"Stored '{request.Title}' with {mp4} and {thumb}.");
    }
}