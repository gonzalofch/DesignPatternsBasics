using Observer.Interfaces;

namespace Observer;

public class ConcreteObservable : IObservable
{
    private List<IObserver> observers;

    public ConcreteObservable()
    {
        observers = new List<IObserver>();
    }

    public void NotifyAll(string? notificationTitle = "New Notification")
    {
        Console.WriteLine("Notificar a todos los Suscriptores");
        foreach (var observer in observers)
        {
            observer.Notify();
        }
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }
}