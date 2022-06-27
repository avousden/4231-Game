using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseRotation : MonoBehaviour
{
    [SerializeField] private float _turnSpeed = 3f;
    Vector3 direction;
    Quaternion rotation;

    private void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        transform.Rotate(horizontal * _turnSpeed * Vector3.up, Space.World);
        direction = new Vector3(horizontal, 0, 0);
        rotation = Quaternion.LookRotation(direction);
    }

    public Quaternion getRotation()
    {
        return rotation;
    }

   
}
