namespace DesignPatterns.Behavioral.Mediator;

public sealed class Runway
{
    public string Code { get; }

    public Runway(string code)
    {
        Code = code.Trim().ToUpperInvariant();
    }

    public override string ToString() => Code;
}