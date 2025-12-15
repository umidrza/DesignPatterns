namespace DesignPatterns.Behavioral.Command;

public class ItalicCommand : IUndoableCommand
{
    private TextEditor _editor;
    private History _history;
    private string _prevText = "";

    public ItalicCommand(TextEditor editor, History history)
    {
        _editor = editor;
        _history = history;
    }

    public void Execute()
    {
        _prevText = _editor.Text;
        _editor.MakeItalic();
        _history.Push(this);
    }

    public void Unexecute()
    {
        _editor.Text = _prevText;
    }
}
