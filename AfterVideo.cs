using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterVideo : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 23f;
    public int sceneIndex = 1;

    //public FadeScreen fadescreen;

    void Start()
    {
        StartCoroutine("ChangeScene");
    }



    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(startingTime);
        //fadescreen.FadeOut();
        //yield return new WaitForSeconds(fadescreen.fadeDuration);
        SceneManager.LoadScene(sceneIndex);
    }


}
