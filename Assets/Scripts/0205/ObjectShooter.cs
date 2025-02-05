using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class ObjectShooter : MonoBehaviour
{
    public ParticleSystem particle;
    GameObject objectGenerator;

    /// <summary>
    /// shooting method
    /// </summary>
    /// <param name="direction">direction of object</param>
    public void Shoot(Vector3 direction)
    {
        GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectGenerator = GameObject.Find("ObjectGenerator");
    }

    private void OnCollisionEnter(Collision collision)
    {
        //GetComponent<Rigidbody>().isKinematic = true;
        particle.Play();

        if (collision.gameObject.tag == "Terrain")
        {
            Destroy(gameObject, 1.0f);
        }
        else if (collision.gameObject.tag == "Target")
        {
            objectGenerator.GetComponent<ObjectGenerator>().AddScore(10);
            Destroy(gameObject, 1.0f);
        }
    }
}
