# State (Behavioral)

State allows an object to alter its behavior when its internal state changes.
The object delegates state-specific behavior to a separate "state" object.

## Roles
- Context: the main object whose behavior changes (Order)
- State interface: common operations for all states (IOrderState)
- Concrete states: implement rules/behavior for each state (DraftState, PaidState, ...)

## When to use
- You have a lifecycle with clear states and allowed transitions
- You want to avoid large if/else or switch statements on "status"
- Behavior changes depending on current state

## Key idea
Each state decides:
- what actions are allowed
- what transitions happen next
The context (Order) stays clean and delegates decisions to the active state.
