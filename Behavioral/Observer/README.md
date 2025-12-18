# Observer (Behavioral)

Observer establishes a one-to-many relationship between objects.
When the subject changes state, all registered observers are notified.

## Roles
- Subject: maintains observers and notifies them 
- Observer interface: receives updates 
- Concrete Observers: react to changes

## When to use
- Multiple parts of the system depend on the same data
- You want loose coupling between data source and consumers
- Push-based event notification is required

## Key idea
The subject knows only the observer interface.
Observers can be added or removed at runtime.
