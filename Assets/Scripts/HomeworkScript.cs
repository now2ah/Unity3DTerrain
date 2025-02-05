using UnityEngine;

public enum Rainbow
{
    RED,
    ORANGE,
    YELLOW,
    GREEN,
    BLUE,
    NAVY,
    PURPLE
}

[AddComponentMenu("HW/Sample01")]
public class HomeworkScript : MonoBehaviour
{
    public bool canJump = true;
    public int money;
    public string[] fruitBasket;
    [Range(1, 99)]
    public float fov;
    public Rainbow rainbow;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
