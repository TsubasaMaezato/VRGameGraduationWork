using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultVR : MonoBehaviour
{
    bool vron;
    // Start is called before the first frame update
    void Start()
    {
        vron = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (vron)
        {
            if (other.gameObject.layer == 6)
            {
                StartCoroutine(VRReady());
                vron = false;
            }
        }

    }

    IEnumerator VRReady()
    {
        yield return new WaitForSeconds(5);

        ResultGameController.vrReady = true;
    }
}
