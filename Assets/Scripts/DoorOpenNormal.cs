using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenNormal : MonoBehaviour
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
        if(gameObject.name == "DoorPosA")
        {
            if (other.gameObject.tag == "Player")
            {
                doorAnim[0].GetComponent<Animator>().SetBool("DoorCloth", true);
                doorAnim[1].GetComponent<Animator>().SetBool("DoorRightLeft", true);

                door.GetComponent<DoorSE>().DoorSEOn();
            }
        }
        if (gameObject.name == "DoorPosB")
        {
            if (other.gameObject.tag == "Player")
            {

                doorAnim[0].GetComponent<Animator>().SetBool("DoorRightLeft", true);
                doorAnim[1].GetComponent<Animator>().SetBool("DoorCloth", true);

                door.GetComponent<DoorSE>().DoorSEOn();
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "DoorPosA")
        {
            if (other.gameObject.tag == "Player")
            {
                doorAnim[0].GetComponent<Animator>().SetBool("DoorCloth", false);
                doorAnim[1].GetComponent<Animator>().SetBool("DoorRightLeft", false);
            }
        }
        if (gameObject.name == "DoorPosB")
        {
            if (other.gameObject.tag == "Player")
            {

                doorAnim[0].GetComponent<Animator>().SetBool("DoorRightLeft", false);
                doorAnim[1].GetComponent<Animator>().SetBool("DoorCloth", false);
            }
        }
    }
}
