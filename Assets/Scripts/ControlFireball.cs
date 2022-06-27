using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFireball : MonoBehaviour
{
    public float speed;
    public float fireRate;
    Vector3 pos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(speed != 0)
        {
            transform.position += transform.forward * (speed * Time.deltaTime);
        }

        if(pos != Vector3.zero)
        {
            Vector3 moveDir = transform.position - pos;
            transform.rotation = Quaternion.LookRotation(moveDir, Vector3.up);
        }
        pos = transform.position;
    }
}
