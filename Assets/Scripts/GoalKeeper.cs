using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class GoalKeeper : MonoBehaviour
{   [SerializeField]
    private float Speed = 1;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");
        Vector3 movementVector = new Vector3(-xMovement * Speed, 0, -zMovement * Speed);
        rb.AddForce(movementVector);
    }
}
