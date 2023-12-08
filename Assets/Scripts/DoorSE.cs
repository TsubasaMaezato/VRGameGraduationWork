using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSE : MonoBehaviour
{
    public AudioClip audioClip;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DoorSEOn()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
