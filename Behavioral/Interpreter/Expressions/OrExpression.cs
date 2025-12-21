namespace DesignPatterns.Behavioral.Interpreter.Expressions;

public sealed class OrExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public OrExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public bool Interpret(Context context)
        => _left.Interpret(context) || _right.Interpret(context);
}