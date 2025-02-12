using UnityEngine;
using System;


public class Player : Character
{
    public event EventHandler OnPlayerDead;

    public override void Initialize()
    {
        _hp = 100;

    }

    public override void Move(Vector3 pos)
    {
        Debug.Log(pos);
        transform.LookAt(pos);
        transform.Translate(pos * Time.deltaTime * 2.0f);
    }

    void _GetInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Move(new Vector3(targetPos.x, 0, targetPos.z));
        }
    }

    private void Update()
    {
        _GetInput();
    }
}
