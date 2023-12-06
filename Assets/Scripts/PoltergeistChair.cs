using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoltergeistChair : MonoBehaviour
{
    Rigidbody rb;
    int chairNum;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        
    }
    public void PoltergeistChairOn()
    {
        if (RoomCollider.roomCol[0])
        {
            chairNum = Random.Range(1, 17);
            if (gameObject.tag == "Room1Poltergeist" && gameObject.name == "Chair" + chairNum)
            {
                rb.AddForce(transform.forward * -10,ForceMode.Force);
            }
        }
        if (RoomCollider.roomCol[1])
        {
            if (gameObject.tag == "Room2Poltergeist")
            {

            }
        }
        if (RoomCollider.roomCol[2])
        {
            if (gameObject.tag == "Room3Poltergeist")
            {

            }
        }
        if (RoomCollider.roomCol[3])
        {
            if (gameObject.tag == "Room4Poltergeist")
            {

            }
        }
        if (RoomCollider.roomCol[4])
        {
            if (gameObject.tag == "Room5Poltergeist")
            {

            }
        }
        if (RoomCollider.roomCol[5])
        {
            if (gameObject.tag == "Room6Poltergeist")
            {

            }
        }
    }
}
