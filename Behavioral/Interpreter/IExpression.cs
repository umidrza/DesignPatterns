namespace DesignPatterns.Behavioral.Interpreter;

public interface IExpression
{
    bool Interpret(Context context);
}