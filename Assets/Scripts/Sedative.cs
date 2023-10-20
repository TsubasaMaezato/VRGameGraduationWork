using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sedative : MonoBehaviour
{
    void Start()
    {
    
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerVR.hp += 30;
            Destroy(gameObject);

            Debug.Log(PlayerVR.hp);
        }
    }
}
