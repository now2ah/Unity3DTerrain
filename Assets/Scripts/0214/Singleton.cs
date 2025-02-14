using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    static T _instance;

    public static T Instance
    {
        get
        {
            if (null == _instance)
            {
                _instance = FindFirstObjectByType<T>();

                if (null == _instance)
                {
                    GameObject singletonObj = new GameObject(typeof(T).Name);
                    _instance = singletonObj.AddComponent<T>();
                }
            }
            
            return _instance;
        }
    }

    protected void Awake()
    {
        if (null == _instance)
            _instance = this as T;
    }
}
