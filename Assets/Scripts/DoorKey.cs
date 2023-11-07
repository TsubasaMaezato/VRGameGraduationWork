using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("LockDoorOn"))
        {
            other.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
