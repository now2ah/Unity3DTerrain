using System;
using UnityEngine;

public class Monster : Character
{
    Player _targetPlayer;
    bool _isStop;

    public override void Initialize()
    {
        _targetPlayer = FindFirstObjectByType<Player>();
        _hp = 50;
        _isStop = false;
        _targetPlayer.OnPlayerGoal += Stop;
    }

    public override void Move(Vector3 pos)
    {
        if (null != _targetPlayer)
        {
            transform.LookAt(pos);
            transform.Translate(Vector3.forward * Time.deltaTime * 2.0f, Space.Self);
        }
    }

    public void Stop(object sender, EventArgs e)
    {
        _isStop = true;
    }

    private void Update()
    {
        if (null != _targetPlayer && !_isStop)
        {
            Move(_targetPlayer.transform.position);
        }
    }
}