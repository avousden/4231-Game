using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFireball : MonoBehaviour
{
    public GameObject firepoint;
    public List<GameObject> fireballs = new List<GameObject>();
    private GameObject fireball;

    public mouseRotation mouseRot;

    // Start is called before the first frame update
    void Start()
    {
        fireball = fireballs[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            spawnFireball();
        }
    }

    void spawnFireball()
    {
        GameObject effect;

        if(firepoint != null)
        {
            effect = Instantiate(fireball, firepoint.transform.position, Quaternion.identity);
            if(mouseRot != null)
            {
                effect.transform.localRotation = mouseRot.getRotation();
            }
        }
    }
}
