using DesignPatterns.Creational.AbstractFactory.Buttons;
using DesignPatterns.Creational.AbstractFactory.Checkboxes;
namespace DesignPatterns.Creational.AbstractFactory.Factories;

public sealed class LightUIFactory : IUIFactory
{
    public IButton CreateButton()
        => new LightButton();

    public ICheckbox CreateCheckbox()
        => new LightCheckbox();
}