namespace DesignPatterns.Behavioral.Command;

public class UndoCommand : ICommand
{
    private History _history;

    public UndoCommand(History history)
    {
        _history = history;
    }

    public void Execute()
    {
        if (_history.Size() > 0)
        {
            var lastCommand = _history.Pop();
            lastCommand.Unexecute();
        }
    }
}