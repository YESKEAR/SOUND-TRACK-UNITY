using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrackPlayer : MonoBehaviour
{
    public AudioClip[] SoundTraki;
    AudioSource FM;
    void Start()
    {
        FM = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(FM.isPlaying == false)
        {
            FM.clip = SoundTraki[Random.Range(0, SoundTraki.Length - 1)];

            FM.Play();
        }
    }
}
