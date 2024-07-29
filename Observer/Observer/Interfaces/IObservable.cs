namespace Observer.Interfaces;

public interface IObservable
{
    public void NotifyAll(string? notificationTitle);
    public void AddObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
}