using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireflies : MonoBehaviour
{

    public ParticleSystem fireflies;


    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(GoToSceneRoutine());
    }
    public IEnumerator GoToSceneRoutine(){
      fireflies.Stop();
      yield return new WaitForSeconds(0f);
      fireflies.Play();
    }
    // Update is called once per frame
    void Update()
    {


      }

}
