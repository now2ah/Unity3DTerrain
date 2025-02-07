using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider masterVolumeSlider;
    [SerializeField] Slider BGMVolumeSlider;
    [SerializeField] Slider SFXVolumeSlider;

    void Awake()
    {
        masterVolumeSlider.onValueChanged.AddListener(_SetMasterVolume);
        BGMVolumeSlider.onValueChanged.AddListener(_SetBGMVolume);
        SFXVolumeSlider.onValueChanged.AddListener(_SetSFXVolume);
    }

    private void _SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("MasterParam", Mathf.Log10(volume) * 20);
    }

    private void _SetBGMVolume(float volume)
    {
        audioMixer.SetFloat("BGMParam", Mathf.Log10(volume) * 20);
    }

    private void _SetSFXVolume(float volume)
    {
        audioMixer.SetFloat("SFXParam", Mathf.Log10(volume) * 20);
    }
}
