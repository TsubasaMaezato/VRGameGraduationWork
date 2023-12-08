using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireObj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision ohter)
    {
        if(Incinerator.fire)
        {
            if (ohter.gameObject.tag == "Stove")
            {
                Destroy(gameObject);
            }
        }
    }
}
