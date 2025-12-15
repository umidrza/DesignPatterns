using DesignPatterns.Behavioral.Command;

var editor = new TextEditor();
var history = new History();

editor.Text = "Hello World";
Console.WriteLine(editor);

var command = new ItalicCommand(editor, history);
command.Execute();
Console.WriteLine(editor);

var undoCommand = new UndoCommand(history);
undoCommand.Execute();
Console.WriteLine(editor);
