using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    void Start()
    {
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Transform DoorTransform = door.transform;
        Vector3 worldAngle = DoorTransform.eulerAngles;

        if (this.gameObject.name == "Sphere")
        {
            for (worldAngle.y = 0; worldAngle.y < 90; worldAngle.y ++)
            {
                DoorTransform.eulerAngles = worldAngle;
            }
        }
        if (this.gameObject.name == "Sphere1")
        {
            for (worldAngle.y = 0; worldAngle.y < -90; worldAngle.y --)
            {
                DoorTransform.eulerAngles = worldAngle;
            }
        }
    }
}
