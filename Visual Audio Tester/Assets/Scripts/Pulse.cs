using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
  
    [SerializeField]
    public Transform player;

    [SerializeField]
    public GameObject prefab;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPulse();
        }

    }

    //Used to spawn an instance of the particle system at the players current position
    void SpawnPulse()
    {
        Instantiate(prefab, player.position, player.rotation);
       
    }

}

