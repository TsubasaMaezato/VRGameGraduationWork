using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost2 : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        Destroy(gameObject, 10);
    }

    void Update()
    {
        transform.Translate(0, 0, 2 * Time.deltaTime * 2);
    }
}
