using UnityEngine;
using UnityEngine.Audio;

public class AudioVisualizer : MonoBehaviour
{
    public AudioClip audioClip;
    public Board[] boards;
    public AudioMixer audioMixer;

    public float minBoard = 150.0f;
    public float maxBoard = 1000.0f;
    public int samples = 64;
    public float[] samplesTest;

    AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        samplesTest = new float[64];

        boards = GetComponentsInChildren<Board>();

        if (audioSource == null)
        {
            audioSource = new GameObject("AudioSource").AddComponent<AudioSource>();
        }
        else
        {
            audioSource = GameObject.Find("AudioSource").GetComponent<AudioSource>();
        }

        audioSource.clip = audioClip;
        audioSource.outputAudioMixerGroup = audioMixer.FindMatchingGroups("Master")[0];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //float[] data = audioSource.GetSpectrumData(samples, 0, FFTWindow.Rectangular);

        //for (int i = 0; i < boards.Length; i++)
        //{
        //    var size = boards[i].GetComponent<RectTransform>().rect.size;

        //    size.y = minBoard + (data[i] * (maxBoard - minBoard));

        //    boards[i].GetComponent<RectTransform>().sizeDelta = size;
        //}

        audioSource.GetSpectrumData(samplesTest, 0, FFTWindow.Rectangular);

        for (int i = 0; i < boards.Length; i++)
        {
            var size = boards[i].GetComponent<RectTransform>().rect.size;

            size.y = minBoard + (samplesTest[i] * (maxBoard - minBoard));

            boards[i].GetComponent<RectTransform>().sizeDelta = size;
        }
    }
}
