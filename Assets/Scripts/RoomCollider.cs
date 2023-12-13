using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCollider : MonoBehaviour
{
    public static bool[] roomCol = new bool[9];
    public static bool Poltergeist;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Poltergeist = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(gameObject.name == "Main")
            {
                roomCol[8] = true;
            }
            if(gameObject.name == "RoomCollider1")
            {
                roomCol[0] = true;
            }
            if (gameObject.name == "RoomCollider2")
            {
                roomCol[1] = true;
            }
            if (gameObject.name == "RoomCollider3")
            {
                roomCol[2] = true;
            }
            if (gameObject.name == "RoomCollider4")
            {
                roomCol[3] = true;
            }
            if (gameObject.name == "RoomCollider5")
            {
                roomCol[4] = true;
            }
            if (gameObject.name == "RoomCollider6")
            {
                roomCol[5] = true;
            }
            if(gameObject.name == "LeftCorriderCollider")
            {
                roomCol[6] = true;
            }
            if (gameObject.name == "RightCorriderCollider")
            {
                roomCol[7] = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.name == "Main")
            {
                roomCol[8] = false;
            }
            if (gameObject.name == "RoomCollider1")
            {
                roomCol[0] = false;
            }
            if (gameObject.name == "RoomCollider2")
            {
                roomCol[1] = false;
            }
            if (gameObject.name == "RoomCollider3")
            {
                roomCol[2] = false;
            }
            if (gameObject.name == "RoomCollider4")
            {
                roomCol[3] = false;
            }
            if (gameObject.name == "RoomCollider5")
            {
                roomCol[4] = false;
            }
            if (gameObject.name == "RoomCollider6")
            {
                roomCol[5] = false;
            }
            if (gameObject.name == "LeftCorriderCollider")
            {
                roomCol[6] = false;
            }
            if (gameObject.name == "RightCorriderCollider")
            {
                roomCol[7] = false;
            }
        }
    }
}
