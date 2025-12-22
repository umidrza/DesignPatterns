using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Facade.Models;
using DesignPatterns.Structural.Facade.Subsystems;

var facade = new VideoUpload(
    new VirusScanner(),
    new Transcoder(),
    new ThumbnailGenerator(),
    new MetadataStore()
);

var ok = new UploadRequest("holiday.mov", "user-1", "My Holiday");
var bad = new UploadRequest("virus_clip.mov", "user-2", "Not Suspicious At All");

Console.WriteLine(facade.Upload(ok));
Console.WriteLine(facade.Upload(bad));