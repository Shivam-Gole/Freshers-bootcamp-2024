using System;
using System.Collections.Generic;

public interface IObserver {
    void Update(string messageFromSubject);
}

public class ConcreteObserver : IObserver {
    public void Update(string messageFromSubject) {
      
    }
}

public class Thread {
    private int id;
    private string state;
    private string priority;
    private string culture;
    private List<IObserver> observers = new List<IObserver>();

    private void Notify() {
        foreach (var observer in observers) {
            observer.Update(state);
        }
    }

    public Thread() {
        state = "start";
        Notify();
    }

    public void Start() {
        state = "running";
        Notify();
    }

    public void Abort() {
        state = "aborted";
        Notify();
    }

    public void Sleep() {
        state = "sleep";
        Notify();
    }

    public void Wait() {
        state = "waiting";
        Notify();
    }

    public void Suspended() {
        state = "suspended";
        Notify();
    }

    public void Subscribe(IObserver observer) {
        observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer) {
        observers.Remove(observer);
    }
}

class Program {
    static void Main(string[] args) {
        Thread obj = new Thread();
        ConcreteObserver observer = new ConcreteObserver();
        obj.Subscribe(observer);

        obj.Start();
        obj.Abort();

        obj.Unsubscribe(observer);
    }
}
