using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Audiotest : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioClip;

    public bool hasPlayed = false;

    public void Play()
    {
        if (!hasPlayed)
        {
            audioSource.PlayOneShot(audioClip);
            StartCoroutine("ChangeScene");
            hasPlayed = true;
        }
        

    }

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(29f);
        SceneManager.LoadScene(3);
    }
}
