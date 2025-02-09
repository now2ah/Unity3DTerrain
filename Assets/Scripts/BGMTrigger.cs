using UnityEngine;

public class BGMTrigger : MonoBehaviour
{
    public MediaManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (null != manager)
                manager.PlayBGM();
        }
    }
}
