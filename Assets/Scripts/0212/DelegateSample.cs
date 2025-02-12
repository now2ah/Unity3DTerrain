using UnityEngine;

public class DelegateSample : MonoBehaviour
{
    delegate void DelegateTest();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DelegateTest delegateTest = new DelegateTest(One);
        delegateTest += Two;
        delegateTest += One;
        delegateTest -= One;
        delegateTest.Invoke();
    }

    private void One()
    {
        Debug.Log("1");
    }

    void Two()
    {
        Debug.Log("2");
    }
}
