using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeHide : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("EyeHideTime",3);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EyeHideTime()
    {
        gameObject.SetActive(false);
    }
}
