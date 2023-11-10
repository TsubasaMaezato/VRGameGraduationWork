using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost2 : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 10);
    }

    void Update()
    {
        transform.Translate(0, 0, 2 * Time.deltaTime * 2);
    }
}
