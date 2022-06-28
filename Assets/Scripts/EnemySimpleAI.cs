using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySimpleAI : MonoBehaviour
{
    public float speed = 2f;
    public float rotate = 2f;
    public float waitForDeath;
    private Transform target;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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

        if(speed > 0)
        {
            animator.SetBool("isMoving", true);
        } else{
            animator.SetBool("isMoving", false);
        }
    }

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag.Equals("Fireball") == true)
        {
            speed = 0;
            animator.SetBool("isDead", true);
            StartCoroutine(Death());
        }

        
            //WaitForSeconds wait = new WaitForSeconds(3);
           // Destroy(gameObject);
        
    }

    IEnumerator Death()
    {
       yield return new WaitForSeconds(waitForDeath);
        animator.SetBool("isDead", false);
        Destroy(gameObject);
        
    }
}
