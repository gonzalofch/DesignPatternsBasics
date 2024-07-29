using Observer.Interfaces;

namespace Observer;

public class ConcreteObserver : IObserver
{
    private string Name;

    public ConcreteObserver(string name)
    {
        Name = name;
    }

    public void Notify()
    {
        Console.WriteLine($"{Name} : Notificación recibida");
    }
}