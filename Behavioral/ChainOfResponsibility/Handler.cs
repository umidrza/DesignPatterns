namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public abstract class Handler
{
    private Handler? _next;

    public Handler SetNext(Handler next)
    {
        _next = next;
        return next;
    }

    public Response Handle(RequestContext context)
    {
        var response = TryHandle(context);
        if (response is not null)
            return response;

        if (_next is null)
            return Response.BadRequest("No handler could process the request.");

        return _next.Handle(context);
    }

    // Return null to pass to next
    protected abstract Response? TryHandle(RequestContext context);
}