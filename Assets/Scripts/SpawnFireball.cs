using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFireball : MonoBehaviour
{
    public GameObject firepoint;
    public List<GameObject> fireballs = new List<GameObject>();
    //public FireballAiming fbAim;
    private GameObject fireball;
    private float timeToFire = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        fireball = fireballs[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1 / fireball.GetComponent<ControlFireball>().fireRate;
            spawnFireball();
        }
    }

    void spawnFireball()
    {
        GameObject effect;

        if(firepoint != null)
        {
            effect = Instantiate(fireball, firepoint.transform.position, firepoint.transform.rotation);
            // if(fbAim != null)
            // {
            //     effect.transform.localRotation = fbAim.GetRotation();
            // }
            
        }
    }
}
