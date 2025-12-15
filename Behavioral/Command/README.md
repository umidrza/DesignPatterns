# Command (Behavioral)

Command encapsulates a request as an object, allowing clients to
parameterize actions, queue or log them, and support undo/redo.

## Roles
- Command: declares execution interface
- Concrete Commands: implement actions 
- Receiver: performs actual work 
- Invoker: triggers commands
- History: stores executed commands for undo

## When to use
- You need undo/redo
- You want to decouple UI from business logic
- You want to log or queue operations

## Key idea
The invoker knows nothing about how the command works.
The command knows the receiver.
