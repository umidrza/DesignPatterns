namespace DesignPatterns.Creational.AbstractFactory.Checkboxes;

public sealed class DarkCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering DARK checkbox");
    }
}