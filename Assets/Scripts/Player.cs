using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class Player : MonoBehaviour
{
    public GameObject camera;
    public float playerSpeed = 2.0f;
    Rigidbody rigidBody;

    void _Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.AddForce(camera.transform.forward * playerSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidBody.AddForce(camera.transform.forward * -1f * playerSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddForce(camera.transform.right * playerSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddForce(camera.transform.right * -1f * playerSpeed);
        }
    }

    private void Awake()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
    }
}
