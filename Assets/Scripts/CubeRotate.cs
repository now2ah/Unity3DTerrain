using UnityEngine;

/// <summary>
/// Make Cube to rotate
/// </summary>
public class CubeRotate : MonoBehaviour
{
    #region comment
    //caption blah blah

    #endregion

    #region variable

    public float x;
    private int y;
    public float z;
    #endregion

    #region method

    void Start()
    {
        y = 10;
        Debug.Log(y);
    }

    void Update()
    {
        transform.Rotate(new Vector3(x * Time.deltaTime, 0.0f, z * Time.deltaTime));
    }

    #endregion
}
