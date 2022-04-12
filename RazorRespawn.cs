using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RazorRespawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;

    void Start()
    {
        StartCoroutine("Respawn");
    }

    private IEnumerator Respawn()
    {
        yield return new WaitForSeconds(25f);
        player.transform.position = respawn_point.transform.position;
    }

    
}
