using DesignPatterns.Behavioral.Memento;

var editor = new Editor();
var history = new History(editor);

history.Backup();
editor.Title = "Hello";
history.Backup();
editor.Content = "Memento Pattern";
history.Backup();
editor.Title = "Hello world";

Console.WriteLine(editor.Title);
Console.WriteLine(editor.Content);

history.Undo();

Console.WriteLine(editor.Title);
Console.WriteLine(editor.Content);

history.ShowHistory();
    