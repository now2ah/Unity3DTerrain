using UnityEngine;
using UnityEngine.SceneManagement;
//using namespace

namespace UnityTutorial
{
    /// <summary>
    /// UnityTutorial
    /// </summary>
    public class SampleA
    {
        
    }
}

public class SampleA
{

}

/// <summary>
/// first Unity script
/// </summary>
public class TestScript : MonoBehaviour
{
    int count = 0;

    void Start()
    {
        Debug.Log("test log");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"count : {count}");
        count++;
    }
}
