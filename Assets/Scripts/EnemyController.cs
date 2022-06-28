using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
     NavMeshAgent agent;

     public float speed = 2f;
     private Transform target;

   private void OnEnable()
   {
        Vector3 targetPosition = GameObject.Find("Target").transform.position;
        //target = targetPosition.position;
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(targetPosition);

        
    
   }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          // var move = speed * Time.deltaTime;
          // transform.position = Vector3.MoveTowards(transform.position, new Vector3(11,0,-23), move);
    }

    
}
