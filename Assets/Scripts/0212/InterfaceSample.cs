using UnityEngine;

public interface ICountable
{
    int Count { get; set; }

    void IncreaseCount();
}

public interface IUsable
{
    void Use();
}

class Potion : ICountable, IUsable
{
    int _count;
    public int Count { get => _count; set => _count = value; }

    public void IncreaseCount()
    {

    }

    public void Use()
    {

    }
}

public class InterfaceSample : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
