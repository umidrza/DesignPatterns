namespace DesignPatterns.Behavioral.Interpreter.Expressions;

public sealed class EqualsExpression : IExpression
{
    private readonly string _key;
    private readonly object _expected;

    public EqualsExpression(string key, object expected)
    {
        _key = key;
        _expected = expected;
    }

    public bool Interpret(Context context)
    {
        var actual = context.Get<object>(_key);
        return Equals(actual, _expected);
    }
}