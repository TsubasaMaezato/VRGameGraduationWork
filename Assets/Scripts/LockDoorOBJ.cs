using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoorOBJ : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnEnable()
    {
        Invoke("DestroyLock",10);
    }
    void DestroyLock()
    {
        gameObject.SetActive(false);
    }
}
