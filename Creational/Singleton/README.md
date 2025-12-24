# Singleton (Creational)

Singleton ensures a class has only one instance
and provides a global access point to it.

This example models an application-wide configuration manager
that loads settings once and exposes them read-only.

## Roles
- Singleton: AppConfiguration
- Client: any part of the application needing configuration

## When to use
- Application configuration
- Feature flags
- Shared caches
- Global coordination points

## Key idea
- Private constructor
- Static access to a single instance
- Controlled initialization
