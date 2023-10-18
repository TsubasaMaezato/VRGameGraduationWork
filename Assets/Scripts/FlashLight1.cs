using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight1 : MonoBehaviour
{
    public GameObject spotLight;
    bool lightOn;
    bool lightTrigger;
    void Start()
    {
        spotLight.SetActive(false);
        lightOn = false;
    }
    void Update()
    {
        if (lightTrigger)
        {
            if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
            {
                if (lightOn)
                {
                    spotLight.SetActive(false);
                    lightOn = false;
                }
                else
                {
                    spotLight.SetActive(true);
                    lightOn = true;
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        lightTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        lightTrigger = false;
    }
}
