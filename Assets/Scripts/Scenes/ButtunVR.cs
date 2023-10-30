using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtunVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource sound;
    bool isPressd;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressd = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressd)
        {
            button.transform.localPosition = new Vector3(0, 0.007f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            isPressd = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressd = false;
        }

    }

    public void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(0, 1, 2);
        sphere.AddComponent<Rigidbody>();
    }

}
