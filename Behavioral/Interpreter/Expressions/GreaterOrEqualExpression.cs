namespace DesignPatterns.Behavioral.Interpreter.Expressions;

public sealed class GreaterOrEqualExpression : IExpression
{
    private readonly string _key;
    private readonly decimal _threshold;

    public GreaterOrEqualExpression(string key, decimal threshold)
    {
        _key = key;
        _threshold = threshold;
    }

    public bool Interpret(Context context)
    {
        var actual = context.Get<decimal>(_key);
        return actual >= _threshold;
    }
}