using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using Random = System.Random;

public class BallBehaviour : MonoBehaviour
{
    public float speed = 0.01f;
    private Rigidbody rb;
    private int xPos = 1;
    private int Lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        Random random = new Random();
        xPos = random.Next(-2, 3);
        Vector3 StartPosition = new Vector3(xPos, 1.2f, -3.5f);

        transform.position = StartPosition;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            Movement();     
    }
    private void Movement()
    {
        Vector3 movementVector = new Vector3(0, 0, 2*speed);
        rb.AddForce(movementVector);
        if(Lives <0)
        {
            speed = -0.01f;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        Random random = new Random();
        xPos = random.Next(-2, 3);
        Vector3 StartPosition = new Vector3(xPos, 1.2f, -3.5f);
        if (other.tag == "Goal")
        {   
            if(Lives ==0)
            {
                Debug.Log("GAME OVER");
            }
            Lives--;
            if(Lives > -1)
            {
                Debug.Log("You have " + Lives + " lives left");

            }
        }  else if(other.tag == "Wall")
        {
            transform.position = StartPosition;
        }
    }
}
