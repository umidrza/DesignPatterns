namespace DesignPatterns.Behavioral.Command;

public sealed class TextEditor
{
    public string Text { get; set; } = string.Empty;

    public void MakeItalic()
    {
        Text = "<i>" + Text + "</i>";
    }

    public override string ToString() => Text;
}