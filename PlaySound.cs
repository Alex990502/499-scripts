using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    // Update is called once per frame
    public void Play()
    {

        audioSource.PlayOneShot(audioClip);

    }
}
