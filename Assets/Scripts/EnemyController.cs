using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
   private void OnEnable()
   {
        Vector3 targetPostition = GameObject.Find("Target").transform.position;
        GetComponent<NavMeshAgent>().SetDestination(targetPostition);
    
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
