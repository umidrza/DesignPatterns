# Facade (Structural)

Facade provides a simple interface to a complex subsystem.
It hides orchestration details and reduces coupling.

This example models a video upload workflow that requires multiple services:
- virus scanning
- transcoding
- thumbnail generation
- metadata storage

## Roles
- Facade: VideoUploadFacade (single entry point)
- Subsystems: VirusScanner, Transcoder, ThumbnailGenerator, MetadataStore

## When to use
- You want a simple API over a complex workflow
- You want to reduce dependencies on many subsystem classes
- You want to centralize orchestration logic

## Key idea
Clients call the facade, not the subsystem directly.
Subsystems remain reusable and independent.
