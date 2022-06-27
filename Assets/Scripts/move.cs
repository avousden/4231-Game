using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float movementForce = 10f;
    private double maxVelocity = 10f; 

    private void Awake() => rigidbody = GetComponent<Rigidbody>();

    private void FixedUpdate()
    {
        if(rigidbody.velocity.magnitude >= maxVelocity)
            return;

        if(Input.GetKey(KeyCode.W))
            rigidbody.AddForce(movementForce * transform.forward);

        if(Input.GetKey(KeyCode.S))
            rigidbody.AddForce(movementForce * -transform.forward);

        if(Input.GetKey(KeyCode.D))
            rigidbody.AddForce(movementForce * transform.right);

        if(Input.GetKey(KeyCode.A))
            rigidbody.AddForce(movementForce * -transform.right);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
