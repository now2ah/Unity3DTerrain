using UnityEngine;

public interface IActionable
{
    void Action();
}

public abstract class Enemy
{

}

public class Goblin : Enemy, IActionable
{
    public void Action()
    {
        Debug.Log("Goblin takes action");
    }
}

public class Slime : Enemy, IActionable
{
    public void Action()
    {
        Debug.Log("Slime takes action");
    }
}

public class Wolf : Enemy, IActionable
{
    public void Action()
    {
        Debug.Log("Wolf takes action");
    }
}
