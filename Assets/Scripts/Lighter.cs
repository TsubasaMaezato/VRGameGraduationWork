using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    public static bool lighterOn;
    bool lighterTrigger;

    public GameObject particle;

    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        lighterTrigger = false;
        lighterOn = true;

        particle.SetActive(false);
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
                    particle.SetActive(false);
                }
                else
                {
                    animator.SetBool("LighterOn", true);
                    lighterOn = true;
                    particle.SetActive(true);
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.layer == 6)
        {
            lighterTrigger = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            lighterTrigger = false;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (Incinerator.fuelsNum == 3)
        {
            if (other.gameObject.tag == "Stove" && lighterOn)
            {
                Incinerator.fire = true;
                Destroy(gameObject);
            }
        }
    }
}
