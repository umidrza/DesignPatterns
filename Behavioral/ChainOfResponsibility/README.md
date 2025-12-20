# Chain of Responsibility (Behavioral)

Chain of Responsibility lets you pass a request through a chain of handlers.
Each handler decides whether to:
- handle the request
- pass it to the next handler
- stop the chain by returning an error/response

This example models an API pipeline:
Authentication -> Rate limiting -> Validation -> Endpoint

## Roles
- Handler base: defines linking and forwarding (Handler)
- Concrete handlers: implement checks/logic
- Request context: data being processed (RequestContext)

## When to use
- Middleware/pipelines (HTTP, message processing)
- Validation and authorization flows
- Approval workflows (manager -> director -> VP)

## Key idea
The sender doesn't know which handler will process the request.
You can reorder, add, or remove handlers without changing client code.
