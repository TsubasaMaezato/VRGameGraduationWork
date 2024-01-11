using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenTanpin : MonoBehaviour
{
    public GameObject[] doorAnim;
    public GameObject door;

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
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "DoorPosA2")
        {
            if (other.gameObject.tag == "Player")
            {
                doorAnim[0].GetComponent<Animator>().SetBool("DoorRightLeft", true);
            }
        }
        if (gameObject.name == "DoorPosB2")
        {
            if (other.gameObject.tag == "Player")
            {
                doorAnim[0].GetComponent<Animator>().SetBool("DoorCloth", true);
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "DoorPosA2")
        {
            if (other.gameObject.tag == "Player")
            {
                StartCoroutine(DoorClose1());
            }
        }
        if (gameObject.name == "DoorPosB2")
        {
            if (other.gameObject.tag == "Player")
            {
                StartCoroutine(DoorClose2());
            }
        }
    }
    IEnumerator DoorClose1()
    {
        yield return new WaitForSeconds(2);

        doorAnim[0].GetComponent<Animator>().SetBool("DoorRightLeft", false);
    }

    IEnumerator DoorClose2()
    {
        yield return new WaitForSeconds(2);

        doorAnim[0].GetComponent<Animator>().SetBool("DoorCloth", false);
    }
}
