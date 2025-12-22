# Proxy (Structural)

Proxy provides a stand-in object that controls access to another object.
It can add lazy loading, security, caching, or logging.

This example demonstrates:
- Virtual Proxy (lazy loading)
- Protection Proxy (authorization)

## Roles
- Subject: common interface (IDocument)
- Real Subject: performs actual work (RealDocument)
- Proxy: controls access to real subject (SecureDocumentProxy)

## When to use
- Expensive object creation (lazy load)
- Access control
- Logging, caching, or remote access

## Key idea
Client code talks to the interface.
Proxy decides when and how to access the real object.
