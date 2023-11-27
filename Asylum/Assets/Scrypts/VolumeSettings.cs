using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer Mixer;
    [SerializeField] private Slider MusicSlider;
    [SerializeField] private Slider SFXSlider;
    [SerializeField] private Slider FlashSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetSFXVolume();
            SetFlashVolume();
        }
   
    }

    public void SetMusicVolume()
    {
        float volume = MusicSlider.value;
        Mixer.SetFloat("Music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    public void SetSFXVolume()
    {
        float volume = SFXSlider.value;
        Mixer.SetFloat("SFX", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }

    public void SetFlashVolume()
    {
        float volume = FlashSlider.value;
        Mixer.SetFloat("Flash", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("FlashVolume", volume);
    }

    private void LoadVolume()
    {
        MusicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        FlashSlider.value = PlayerPrefs.GetFloat("FlashVolume");

        SetMusicVolume();
        SetSFXVolume();
        SetFlashVolume();
    }
}
