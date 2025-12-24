namespace DesignPatterns.Creational.Prototype;

public interface IPrototype<T>
{
    T Clone();
}