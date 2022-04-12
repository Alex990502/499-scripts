using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public int index = 1;

    public void GoToScene(){
      StartCoroutine(GoToSceneRoutine());
    }

    public IEnumerator GoToSceneRoutine(){
      fadeScreen.FadeOut();
      yield return new WaitForSeconds(fadeScreen.fadeDuration);
      SceneManager.LoadScene(index);
    }


}
