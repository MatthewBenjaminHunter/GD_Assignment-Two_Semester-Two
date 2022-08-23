using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPrefab : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(wait());
    }

    
    void Update()
    {
        
    }


    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);

        Destroy(this.gameObject);
    }

}
