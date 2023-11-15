using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostOBJScript : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnEnable()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("UICostBool",true);
    }
}
