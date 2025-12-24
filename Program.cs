using DesignPatterns.Creational.AbstractFactory.Factories;

static void RenderUI(IUIFactory factory)
{
    factory.CreateButton().Render();
    factory.CreateCheckbox().Render();
}

// Switch entire family by changing factory
IUIFactory factory;

factory = new LightUIFactory();
RenderUI(factory);

Console.WriteLine();

factory = new DarkUIFactory();
RenderUI(factory);
