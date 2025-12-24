namespace DesignPatterns.Creational.AbstractFactory.Checkboxes;

public sealed class LightCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering LIGHT checkbox");
    }
}