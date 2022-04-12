using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundLater : MonoBehaviour
{
    public AudioSource sound;
    public float delay = 95f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoToSceneRoutine());
    }

    public IEnumerator GoToSceneRoutine(){

      yield return new WaitForSeconds(delay);
      sound.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
