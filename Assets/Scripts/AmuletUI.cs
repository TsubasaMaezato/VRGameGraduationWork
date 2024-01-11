using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmuletUI : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        Invoke("AmuletEnd", 6);
    }
    void Update()
    {
        
    }
    void AmuletEnd()
    {
        gameObject.SetActive(false);
    }
}
