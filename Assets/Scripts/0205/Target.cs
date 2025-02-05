using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{
    ObjectGenerator _generator;
    public float speed = 10.0f;
    public float maxMoveRange = 10.0f;
    bool _isRight;
    Vector3 _startPosition;


    void _Move()
    {
        if (Vector3.Distance(transform.position, _startPosition) > maxMoveRange)
            _isRight = !_isRight;

        if (_isRight)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Projectile")
        {
            _generator.curTargetAmount--;
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _startPosition = transform.position;
        _generator = FindFirstObjectByType<ObjectGenerator>();
        int num = Random.Range(0, 1);
        if (num == 0)
            _isRight = true;
        else
            _isRight= false;
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
    }
}
