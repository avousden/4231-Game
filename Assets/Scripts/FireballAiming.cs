using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAiming : MonoBehaviour
{
    public Camera cam;
    public float maxLength;

    private Vector3 direction;
    private Quaternion rotation;
    private Ray rayMouse;
    private Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var mousePos = Input.mousePosition;
        rayMouse = cam.ScreenPointToRay(mousePos);
        if(Physics.Raycast(rayMouse.origin, rayMouse.direction,out hit, maxLength))
        {
            rotateToMouse(gameObject, hit.point);
        } else
        {
            var pos = rayMouse.GetPoint(maxLength);
            rotateToMouse(gameObject, pos);
        }
        
    }

    void rotateToMouse(GameObject obj, Vector3 destination) //fireball
    {
        direction = destination - obj.transform.position;
        rotation = Quaternion.LookRotation(direction);
        obj.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotation, 1);
    }

    public Quaternion GetRotation()
    {
        return rotation;
    }
}
