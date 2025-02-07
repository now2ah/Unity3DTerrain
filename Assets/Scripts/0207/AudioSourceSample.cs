using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AudioSourceSample : MonoBehaviour
{
    AudioSource audioSource;
    AudioClip audioClip;
    public Button playButton;
    public Button pauseButton;
    public Button stopButton;
    public TextMeshProUGUI stateText;

    void PlayAudioSource()
    {
        if (null != audioSource)
        {
            audioSource.Play();
            stateText.text = "Playing...";
            Debug.Log("Playing...");
        }
    }

    void PauseAudioSource()
    {
        if (null != audioSource)
        {
            audioSource.Pause();
            stateText.text = "-Paused-";
            Debug.Log("-Paused-");
        }
    }

    void StopAudioSource()
    {
        if (null != audioSource)
        {
            audioSource.Stop();
            stateText.text = "-Stopped-";
            Debug.Log("-Stopped");
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playButton.onClick.AddListener(PlayAudioSource);
        pauseButton.onClick.AddListener(PauseAudioSource);
        stopButton.onClick.AddListener(StopAudioSource);

        AudioClip clip = Resources.Load("Sanctuary") as AudioClip;
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
    }
}
