namespace DesignPatterns.Behavioral.Command;

public class History
{
    private readonly Stack<IUndoableCommand> commands = new();

    public void Push(IUndoableCommand command)
    {
        commands.Push(command);
    }

    public IUndoableCommand Pop()
    {
        return commands.Pop();
    }

    public int Size()
    {
        return commands.Count;
    }
}