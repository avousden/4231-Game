using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
     NavMeshAgent agent;

   private void OnEnable()
   {
        Vector3 targetPosition = GameObject.Find("Target").transform.position;
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
        
    }

    
}
