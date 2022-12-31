using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D ballRigidbody;
    [SerializeField] float ballSpeed;
    [SerializeField] AudioSource contactSound;


   
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
        ballRigidbody.AddForce(new Vector2(ballSpeed, ballSpeed));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="wall")
        {
            contactSound.Play();

        }
    }

}
