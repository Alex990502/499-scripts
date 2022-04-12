using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endreveal : MonoBehaviour
{
    public GameObject screen;
    public GameObject TV;
    // Start is called before the first frame update
    void Start()
    {
        screen.SetActive(false);
        StartCoroutine(GoToSceneRoutine());
    }

    public IEnumerator GoToSceneRoutine(){
      yield return new WaitForSeconds(40f);
      screen.SetActive(true);
      TV.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
