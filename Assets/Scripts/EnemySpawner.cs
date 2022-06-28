using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawner : MonoBehaviour
{
    NavMeshAgent agent;

    public List<GameObject> enemies = new List<GameObject>();
    public Vector3 spawnBounds;
    public float spawnTimer;
    public float spawnTimeMax;
    public float spawnTimeMin;
    public int waitStart;
    public bool stop;

    int randEnemy;

private void OnEnable()
   {
        //agent = GetComponent<NavMeshAgent>();
        //agent.enabled = false;
   }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitSpawns());
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer = Random.Range(spawnTimeMin, spawnTimeMax);
    }

    IEnumerator WaitSpawns()
    {
        yield return new WaitForSeconds(waitStart);
        while(!stop)
        {
            randEnemy = Random.Range(0, 3);
            //Vector3 spawnPosition = new Vector3(Random.Range(-spawnBounds.x, spawnBounds.x), 0, Random.Range(-spawnBounds.z, spawnBounds.z));
            Vector3 spawnPosition = new Vector3(Random.Range(-132, 100), 0, Random.Range(-194, 138));
            
            Instantiate(enemies[randEnemy], spawnPosition , gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnTimer);
        }
    }
}
