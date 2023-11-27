using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Source")]

    public AudioSource MusicSource;
    public AudioSource SFXSource;
    public AudioSource Rain;

    [Header("Clip")]

    public AudioClip MusicBackground;
    public AudioClip bottons;
    public AudioClip RainMusic;

    private void Start()
    {
        MusicSource.clip = MusicBackground;
        MusicSource.Play();
        Rain.clip = RainMusic;
        Rain.Play();

    }

    public void HoverSound (AudioClip clip)
    {
        SFXSource.PlayOneShot (bottons);
    }

    public void ClickSound(AudioClip clip)
    {
        SFXSource.PlayOneShot(bottons);
    }

}
