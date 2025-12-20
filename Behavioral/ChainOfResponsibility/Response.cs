namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public sealed class Response
{
    public int StatusCode { get; }
    public string Message { get; }

    private Response(int statusCode, string message)
    {
        StatusCode = statusCode;
        Message = message;
    }

    public static Response Ok(string message) => new(200, message);
    public static Response Unauthorized(string message) => new(401, message);
    public static Response TooManyRequests(string message) => new(429, message);
    public static Response BadRequest(string message) => new(400, message);

    public override string ToString() => $"{StatusCode} - {Message}";
}