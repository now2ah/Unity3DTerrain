using System;
using UnityEngine;

public class Player : Character
{
    public event EventHandler OnPlayerGoal;
    Rigidbody _rigidbody;

    public override void Initialize()
    {
        _hp = 50;
        _rigidbody = GetComponent<Rigidbody>();
    }

    public override void Move(Vector3 pos)
    {
        if (_rigidbody != null)
        {
            _rigidbody.AddForce((pos - transform.position) * 1.0f, ForceMode.Impulse);
        }
    }

    void _GetInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Move(hit.point);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            OnPlayerGoal(this, EventArgs.Empty);
        }
    }

    private void Update()
    {
        _GetInput();
    }
}
