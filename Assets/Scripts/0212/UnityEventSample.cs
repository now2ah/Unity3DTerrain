using System;
using UnityEngine;

public class PortalEvent
{
    public event EventHandler onMaximumKill;
    int killCount = 0;

    void _IncreaseKillCount() => killCount++;
    public void KillMonster()
    {
        _IncreaseKillCount();

        if (killCount == 5)
        {
            killCount = 0;
            onMaximumKill(this, EventArgs.Empty);
        }
        else
        {
            Debug.Log("Killed a one Monster");
        }
    }
}

public class UnityEventSample : MonoBehaviour
{
    PortalEvent portalEvent;

    private void Start()
    {
        portalEvent = new PortalEvent();
        portalEvent.onMaximumKill += new EventHandler(_OpenPortal);

        for (int i=0; i<5; i++)
        {
            portalEvent.KillMonster();
        }
    }

    private void _OpenPortal(object sender, EventArgs e)
    {
        Debug.Log("Portal is opened");
    }
}
