using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryReduction : MonoBehaviour
{
    public PlayerHealth playerhealth;

    public float elapsedTime = 0f;

    void Start()
    {
        InvokeRepeating("OvertimeDamage", 1f, 1f);  //Time in which the damage is executed which is currently 1 second
    }


    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime >= 1f)
        {
            elapsedTime = elapsedTime % 1f;
        }

    }

    void OvertimeDamage()
    {
        //Debug.Log(Time.time); Displays time in which the instance of damage takes place
        playerhealth.TakeDamage(1);
    }

    IEnumerator BatteryLoss()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
        }
    }



}

