using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
     [SerializeField]float steerSpeed = 300;
     [SerializeField]float moveSpeed = 25;
     [SerializeField]float slowSpeed = 15f;
     [SerializeField]float boostSpeed = 35f;

   
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;
       transform.Rotate(0, 0, -steerAmount); 
       transform.Translate(0, moveAmount, 0);

    }

    void OnCollisionEnter2D(Collision2D other) 
     {
            moveSpeed = slowSpeed;
    }

     void OnTriggerEnter2D(Collider2D other) 
     {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}
