using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenTanpin : MonoBehaviour
{
    public GameObject[] doorAnim;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {

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
                doorAnim[0].GetComponent<Animator>().SetBool("DoorRightLeft", false);
            }
        }
        if (gameObject.name == "DoorPosB2")
        {
            if (other.gameObject.tag == "Player")
            {
                doorAnim[0].GetComponent<Animator>().SetBool("DoorCloth", false);
            }
        }
    }
}
