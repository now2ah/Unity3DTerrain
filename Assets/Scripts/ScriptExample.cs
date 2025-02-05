using UnityEngine;

/// <summary>
/// Unity Attribute
/// </summary>
[AddComponentMenu("CustomUtility/ScriptExample")]
public class ScriptExample : MonoBehaviour
{
    [Range(1, 99)]
    public int level;

    [Range(0, 100)]
    public int volume;

    [Header("Name")]
    public string playerName;

    [TextArea]
    public string talk01;
     
    [TextArea(1, 3)]
    public string talk02;

    [TextArea(5, 7)]
    public string talk03;

    [Tooltip("is Player Dead")]
    public bool isDead = true;

    [ContextMenu("HelloEveryone")]
    void HelloEveryone() 
    {
        Debug.Log("Hi Everyone");
    }


}
