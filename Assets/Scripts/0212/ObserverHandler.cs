using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObserverHandler : MonoBehaviour, ISubject
{
    List<UObserver> observerList = new List<UObserver>();

    delegate void NotifyHandler();
    NotifyHandler _notifyHandler;

    

    public void Add(UObserver observer)
    {
        observerList.Add(observer);
    }

    public void Remove(UObserver observer)
    {
        observerList.Remove(observer);
    }

    public void Notify()
    {
        foreach (UObserver observer in observerList)
        {
            observer.OnNotify();
        }
    }

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TestObserver observer1 = new TestObserver();
        TestObserver2 observer2 = new TestObserver2();

        _notifyHandler += new NotifyHandler(observer1.OnNotify);
        _notifyHandler += observer2.OnNotify;
        _notifyHandler.Invoke();

        ObserverHandler handler = new ObserverHandler();
        handler.Add(observer1);
        handler.Add(observer2);
        handler.Notify();


        Action action;
        Action<int> paramAction;
        Func<int> intFunc;

        action = ActionTest;
        paramAction = ActionTest;
        intFunc = ActionReturnTest;
        Func<int, float> funcTest = (x) => (float)x;
    }
    public void ActionTest() { }
    public void ActionTest(int a) { }
    public int ActionReturnTest() { return 0; }
}
