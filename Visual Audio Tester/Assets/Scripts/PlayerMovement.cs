using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public PlayerHealth playerhealth;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Simple x and y 2d movement of the player
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //Method used to implament movement and speed
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    //Method used to damage player when hitting wall
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Level")
        {
            playerhealth.TakeDamage(10);
        }
    }

    //knockback to be added here
}

//-------Mechanics to add--------
// -cooldown on pulse
// -Checkpoints and knock back
