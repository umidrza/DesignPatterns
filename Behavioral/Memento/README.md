# Memento (Behavioral)

Memento captures an object's state at a moment in time and allows restoring it later,
without exposing internal details of that object.

## Roles
- Originator: the object whose state we want to save/restore (Editor)
- Memento: immutable snapshot of state (EditorState)
- Caretaker: manages snapshots, does not inspect them (History)

## When to use
- Undo/Redo in editors
- Checkpoints in workflows
- Rollback for in-memory operations

## Key idea
The caretaker stores mementos but cannot read/modify internal state.
Only the originator can create and consume its mementos.

