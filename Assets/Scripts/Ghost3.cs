using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost3 : MonoBehaviour
{
    int num;
    void Start()
    {
        Destroy(gameObject, 6);

        num = Random.Range(0, 3);
        gameObject.GetComponent<Animator>().SetInteger("Ghos3On", num);
    }

    void Update()
    {
        
    }
}
