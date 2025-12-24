using DesignPatterns.Creational.AbstractFactory.Buttons;
using DesignPatterns.Creational.AbstractFactory.Checkboxes;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public sealed class DarkUIFactory : IUIFactory
{
    public IButton CreateButton()
        => new DarkButton();

    public ICheckbox CreateCheckbox()
        => new DarkCheckbox();
}