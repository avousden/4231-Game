using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    
    CharacterController _characterController;
    public bool isGrounded;
    

    void Awake() => _characterController = GetComponent<CharacterController>();

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 movement = transform.TransformDirection(direction) * _moveSpeed;
        isGrounded = _characterController.SimpleMove(movement);

        if(!isGrounded)
        {
            direction = new Vector3(0,-1, 0);
        }

        
    }
}
