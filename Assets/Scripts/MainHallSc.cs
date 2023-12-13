using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHallSc : MonoBehaviour
{
    bool DoorOn;

    public GameObject doorAnimObj;
    public GameObject[] door;
    // Start is called before the first frame update
    void Start()
    {
        DoorOn = true;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (DoorOn)
            {
                door[0].GetComponent<Animator>().SetBool("DoorCloth", false);
                door[1].GetComponent<Animator>().SetBool("DoorRightLeft", false);
                DoorOn = false;
                doorAnimObj.GetComponent<DoorSE>().DoorSEOn();
            }
        }
    }
}
