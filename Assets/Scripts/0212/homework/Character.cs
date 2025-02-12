using System;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public interface IMovable
{
    void Move(Vector3 pos);
}

public abstract class Character : MonoBehaviour, IMovable
{
    protected int _hp;

    public abstract void Initialize();
    public abstract void Move(Vector3 pos);
}
