using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Rotate : MonoBehaviour
{
    public GameObject window;
    public float rotateSpeed = 1;
    public float rotateAngle = 0;

    public float time = 0;
    public bool reverse;
    public bool isLeft;



    private bool start = false;

    // Start is called before the first frame update
    void Start()
    {
        if(reverse){
          rotateSpeed *= -1;
        }
        StartCoroutine(GoToSceneRoutine());
    }

    public IEnumerator GoToSceneRoutine(){
      yield return new WaitForSeconds(time);
      start = true;
    }

    // Update is called once per frame
    void Update()
    {
      if(start){
          if(!isLeft){
            if(window.transform.rotation.eulerAngles.y < rotateAngle){
                rotateSpeed = 0;

            }
          }
          else{
            if(window.transform.rotation.eulerAngles.y > rotateAngle){
                rotateSpeed = 0;

            }
          }
          window.transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
          //Debug.Log("Euler Angle: " + window.transform.rotation.eulerAngles.y);

      }

    }
}
