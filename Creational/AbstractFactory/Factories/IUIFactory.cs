using DesignPatterns.Creational.AbstractFactory.Buttons;
using DesignPatterns.Creational.AbstractFactory.Checkboxes;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public interface IUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}