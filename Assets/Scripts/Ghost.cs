using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    int num;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10);

        num = Random.Range(0, 2);
        gameObject.GetComponent<Animator>().SetInteger("Ghost1On",num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
