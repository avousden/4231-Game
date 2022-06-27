using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //forward
        if(Input.GetKey("w"))
        {
            animator.SetBool("isMovingForward", true);
        } else
        {
            animator.SetBool("isMovingForward", false);
        }

        //backward
        if(Input.GetKey("s"))
        {
            animator.SetBool("isMovingBackward", true);
        } else
        {
            animator.SetBool("isMovingBackward", false);
        }

        //left
        if(Input.GetKey("a"))
        {
            animator.SetBool("isMovingLeft", true);
        } else
        {
            animator.SetBool("isMovingLeft", false);
        }

        //right
        if(Input.GetKey("d"))
        {
            animator.SetBool("isMovingRight", true);
        } else
        {
            animator.SetBool("isMovingRight", false);
        }

        //attack
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetBool("isAttacking", true);
        }else
        {
            animator.SetBool("isAttacking", false);
        }
    }
}
