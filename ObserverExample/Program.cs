using ObserverExample.Contract;

public class Subject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        Console.WriteLine("Subject: Attached an observer.");
        this._observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        this._observers.Remove(observer);
        Console.WriteLine("Subject: Detached an observer.");
    }

    public void Notify()
    {
        Console.WriteLine("Subject: Notifying observers...");

        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public void SomeBusinessLogic()
    {
        Console.WriteLine("\nSubject: I'm doing something important.");

        Thread.Sleep(15);

        Console.WriteLine("Subject: My state has just changed to: ");
        this.Notify();
    }
}

class ConcreteObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        Console.WriteLine("ConcreteObserverA: Reacted to the event.");
    }
}

class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        Console.WriteLine("ConcreteObserverB: Reacted to the event.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var subject = new Subject();

        var observerA = new ConcreteObserverA();
        subject.Attach(observerA);

        var observerB = new ConcreteObserverB();
        subject.Attach(observerB);

        subject.SomeBusinessLogic();
        subject.SomeBusinessLogic();

        subject.Detach(observerB);

        subject.SomeBusinessLogic();
    }
}
