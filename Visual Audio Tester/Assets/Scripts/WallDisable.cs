using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDisable : MonoBehaviour
{
    public SpriteRenderer sr;

    bool waitRunning;

    void Start()
    {
        sr.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(sr.enabled == true && waitRunning == false)
        {
            StartCoroutine(wait());   
        }
    }

    //Timer for wall dissapearing and updating
    IEnumerator wait()
    {
        waitRunning = true;
        yield return new WaitForSeconds(5);
        sr.enabled = false;
        waitRunning = false;
    }
}
