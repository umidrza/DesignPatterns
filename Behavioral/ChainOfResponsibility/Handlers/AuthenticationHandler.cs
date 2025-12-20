namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers;

public sealed class AuthenticationHandler : Handler
{
    protected override Response? TryHandle(RequestContext context)
    {
        // Public endpoints could be skipped, but here we enforce auth for /orders
        if (context.Path.StartsWith("/orders"))
        {
            if (string.IsNullOrWhiteSpace(context.AuthToken) || context.AuthToken != "valid-token")
                return Response.Unauthorized("Missing or invalid token.");
        }

        return null; // continue
    }
}
