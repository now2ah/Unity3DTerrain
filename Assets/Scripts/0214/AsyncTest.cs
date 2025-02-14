using System.Threading.Tasks;
using UnityEngine;

public class AsyncTest : MonoBehaviour
{
    async void AsyncTaskTest()
    {
        await Task.Delay(1000);
        Debug.Log("AsyncTask Done.");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AsyncTaskTest();
        Debug.Log("this is main");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
