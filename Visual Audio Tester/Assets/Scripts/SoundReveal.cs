using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundReveal : MonoBehaviour
{

    //Have to make reference to the particle system and particle events in order to particle collision
  
    public ParticleSystem part;
    public List<ParticleCollisionEvent> collisionEvents;

    SpriteRenderer sr;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnParticleCollision(GameObject other)
    {
        //Don't know how this works but this is required in order to resolve particle collision
        int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);

        sr=  other.GetComponent<SpriteRenderer>();

        if(other.tag== "Level")
        {
            sr.enabled = true;
        }
  
    }

}
