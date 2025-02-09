using UnityEngine;

public class MediaManager : MonoBehaviour
{
    public GameObject tvScreen;
    public AudioSource bgmAudioSource;
    
    public void PlayBGM()
    {
        if (null != bgmAudioSource)
        {
            bgmAudioSource.Play();
        }
    }

    public void TurnOnTV()
    {
        if (null != tvScreen)
        {
            tvScreen.SetActive(true);
        }
    }
}
