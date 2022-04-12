using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public GameObject light;
    public int rotateSpeed = 50;
    public float time = 95;
    private bool play = false;
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(GoToSceneRoutine());
    }

    public IEnumerator GoToSceneRoutine(){

      yield return new WaitForSeconds(time);
      play = true;
    }

    // Update is called once per frame
    void Update()
    {
      if(play){
        light.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
      }
    }
}
