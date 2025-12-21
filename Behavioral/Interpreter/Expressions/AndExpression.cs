namespace DesignPatterns.Behavioral.Interpreter.Expressions;

public sealed class AndExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public AndExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public bool Interpret(Context context)
        => _left.Interpret(context) && _right.Interpret(context);
}