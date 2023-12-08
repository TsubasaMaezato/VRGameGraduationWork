using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    public static bool lighterOn;
    bool lighterTrigger;

    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        lighterTrigger = false;
        lighterOn = true;
    }
    void Update()
    {
        if (lighterTrigger)
        {
            if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
            {
                if (lighterOn)
                {
                    animator.SetBool("LighterOn", false);
                    lighterOn = false;
                }
                else
                {
                    animator.SetBool("LighterOn", true);
                    lighterOn = true;
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        lighterTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        lighterTrigger = false;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (Incinerator.fuelsNum == 3)
        {
            if (other.gameObject.tag == "Stove" && lighterOn)
            {
                Incinerator.fire = true;
            }
        }
    }
}
