using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    Vector3 pos;
    Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        /*pos = gameObject.transform.position;
        rot = gameObject.transform.rotation;*/
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PositionReset()
    {
       /* gameObject.transform.position = pos;
        gameObject.transform.rotation = rot;*/
    }
}
