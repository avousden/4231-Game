using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySimpleAI : MonoBehaviour
{
    public float speed = 2f;
    public float rotate = 2f;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //turn
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotate * Time.deltaTime);
        //transform.rotation = Quaternion.LookRotation(target.position - transform.position, Vector3.up);
        //move
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
