namespace DesignPatterns.Creational.AbstractFactory.Buttons;

public sealed class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering LIGHT button");
    }
}