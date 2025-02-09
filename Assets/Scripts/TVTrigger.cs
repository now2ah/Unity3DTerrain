using UnityEngine;

public class TVTrigger : MonoBehaviour
{
    public MediaManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (null != manager)
                manager.TurnOnTV();
        }
    }
}
