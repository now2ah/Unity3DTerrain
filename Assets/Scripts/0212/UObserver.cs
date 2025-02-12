using UnityEngine;

public interface ISubject
{
    public void Add(UObserver observer);
    public void Remove(UObserver observer);
    public void Notify();
}

public abstract class UObserver
{
    public abstract void OnNotify();
}

public class TestObserver : UObserver
{
    public override void OnNotify()
    {
        Debug.Log("1");
    }
}

public class TestObserver2 : UObserver
{
    public override void OnNotify()
    {
        Debug.Log("2");
    }
}
