# Mediator (Behavioral)

Mediator centralizes complex communications and control logic between objects,
so they don't refer to each other directly.

This example models an Air Traffic Control tower coordinating aircraft:
- Aircraft request landing/takeoff
- The tower grants or queues requests
- Aircraft never talk to other aircraft directly

## Roles
- Mediator interface: IAirTrafficControl
- Concrete mediator: AirTrafficControlTower
- Colleagues: Aircraft
- Shared resource: Runway (managed by mediator)

## When to use
- Many-to-many communication becomes tangled
- You want to centralize rules/coordination
- You need to manage a shared resource (locks/queues)

## Key idea
Aircraft are decoupled from each other; coordination is in the tower.
