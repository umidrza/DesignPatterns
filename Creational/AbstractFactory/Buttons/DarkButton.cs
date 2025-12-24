namespace DesignPatterns.Creational.AbstractFactory.Buttons;

public sealed class DarkButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering DARK button");
    }
}