using UnityEngine;

public class Entity : MonoBehaviour
{

    public void Rotate()
    {
        transform.Rotate(Vector3.up, 180f);
    }

    public void Move()
    {
        transform.position += (transform.forward * 5.0f);
    }
}
